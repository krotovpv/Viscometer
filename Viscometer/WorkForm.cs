using System;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using Viscometer.Response;
using Viscometer.Stand;

namespace Viscometer
{
    public partial class WorkForm : Form
    {
        string dataTail = string.Empty;
        SerialPort serialPort = null;
        DataRow dataRowTest = null;
        DataRow dataRowProgramm = null;
        string idTest = string.Empty;
        string numOrder = string.Empty;
        string nameCompound;
        TestType testType;
        RotorType rotorSize;
        
        public WorkForm(string IdTest)
        {
            InitializeComponent();

            idTest = IdTest;
            dataRowTest = DataBase.GetData($"SELECT * FROM [dbo].[Tests] WHERE idTest = '{IdTest}'").Rows[0];
            numOrder = DataBase.GetData($"SELECT numOrder FROM [dbo].[Orders] WHERE idOrder = '{dataRowTest["idOrder"]}'").Rows[0]["numOrder"].ToString();
            nameCompound = DataBase.GetData($"SELECT nameCompound FROM [dbo].[Compounds] WHERE idCompound = '{dataRowTest["idCompound"]}'").Rows[0]["nameCompound"].ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblOrder.Text = numOrder;
            lblLoad.Text = dataRowTest["numLoad"].ToString();
            lblCompound.Text = nameCompound;

            using (SelectViscometerForm svForm = new SelectViscometerForm())
            {
                if (svForm.ShowDialog() == DialogResult.OK)
                {
                    this.Text = svForm.SelectPortName;
                    if (svForm.SelectPortName == String.Empty) this.Close();

                    try
                    {
                        serialPort = new SerialPort(svForm.SelectPortName);
                        serialPort.Open();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        this.Close();
                    }
                }
                else
                    this.Close();
            }

            //Задаем программу испытания
            using (SetProgrammForm setProgramm = new SetProgrammForm(serialPort))
            {
                if (setProgramm.ShowDialog() == DialogResult.OK)
                {
                    //меняем статус испытания и записываем примененную программу
                    DataBase.GetData("UPDATE [dbo].[Tests] " +
                        $"SET [idStatus] = '{(int)Status.TestStatus.Work}' ," +
                        $"[loadProgramm] = '{setProgramm.TestPragrammString}' " +
                        $"WHERE [idTest] = '{idTest}'");
                }
                else
                {
                    this.Close(); 
                }
            }

            //Подписываемся на обработку данных ТОЛЬКО после того как со стендом пообщалось окошко задания программы испытания!
            serialPort.DataReceived += SerialPort_DataReceived;
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataTail += ((SerialPort)sender).ReadExisting();

            ParseData();
        }

        private void ParseData()
        {
            string line = String.Empty;
            foreach (char item in dataTail)
            {
                if (item == '\n' || item == '\r')
                {
                    try
                    {
                        ParseLine(line);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    
                    line = String.Empty;
                }
                else
                {
                    line += item;
                }
            }
            dataTail = line;
        }

        private void ParseLine(string line)
        {
            if (line == "") return;
            DataBase.GetData($"INSERT INTO [dbo].[ProcessResponses] ([idTest],[stringFromStand]) VALUES ('{idTest}' ,'{line}')");

            txtData.InvokeEx(() => 
            {
                txtData.AppendText(line + Environment.NewLine);
                txtData.SelectionStart = txtData.Text.Length;
                txtData.ScrollToCaret();
            });

            IResponseOfStand response = ResponseOfStand.Parse(line);
            if (response.GetType() == typeof(ParameterResponse))
            {

            }
            else if (response.GetType() == typeof(StartResponse))
            {
                StartResponse startResponse = response as StartResponse;
                this.InvokeEx(() =>
                {
                    lblTestTime.Text = "Время испытания: " + startResponse.SetTime.ToString();
                    lblTemperature.Text = "Температура: " + startResponse.SetPoint.ToString();
                    lblRelax.Text = "Время релаксации: " + startResponse.Decay.ToString();
                    lblPreheat.Text = "Время прогрева: " + startResponse.Preheat.ToString();
                    lblNum.Text = "Номер: " + startResponse.FactoryNumber.ToString();
                    testType = startResponse.TestType;
                    rotorSize = startResponse.RotorSize;
                });
            }
            else if (response.GetType() == typeof(EndResponse))
            {
                EndResponse endResponse = response as EndResponse;
                if (endResponse.Status == 1)
                {
                    this.InvokeEx(() => 
                    {
                        lblResault.Text = "Успешно";
                        lblResault.BackColor = Color.LightGreen;
                        if (testType == TestType.Viscosity)
                            lblResault.Text = "MU " + endResponse.FinalViscosity.ToString();
                        else if (testType == TestType.Scorch)
                        {
                            if (rotorSize == RotorType.Large)
                                lblResault.Text = $"t35 ({endResponse.T18orT35.ToString()}) - t5 ({endResponse.T3orT5.ToString()}) = Δt ({endResponse.T18orT35 - endResponse.T3orT5})";
                            else if (rotorSize == RotorType.Small)
                                lblResault.Text = $"t18 ({endResponse.T18orT35.ToString()}) - t3 ({endResponse.T3orT5.ToString()}) = Δt ({endResponse.T18orT35 - endResponse.T3orT5})";
                        }

                    });
                    DataBase.GetData($"UPDATE [dbo].[Tests] SET [idStatus] = '{(int)Status.TestStatus.Success}' WHERE [idTest] = '{idTest}'");
                }
                else if (endResponse.Status == 2)
                {
                    this.InvokeEx(() =>
                    {
                        lblResault.Text = "Провалено";
                        lblResault.BackColor = Color.LightCoral;
                    });
                    DataBase.GetData($"UPDATE [dbo].[Tests] SET [idStatus] = '{(int)Status.TestStatus.Fail}' WHERE [idTest] = '{idTest}'");
                }
            }
            else if (response.GetType() == typeof (CurrentResponse))
            {
                CurrentResponse currentResponse = response as CurrentResponse;
                this.InvokeEx(() =>
                {
                    chartValue.Series[0].Points.Add(currentResponse.Viscosity);
                    chartTemperature.Series[0].Points.Add(currentResponse.TemperatureUp);
                    chartTemperature.Series[1].Points.Add(currentResponse.TemperatureDown);
                });
            }
        }

        private void WorkForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                int status = Convert.ToInt16(DataBase.GetData($"SELECT idStatus FROM [dbo].[Tests] WHERE idTest = '{idTest}'").Rows[0]["idStatus"]);
                if (status == (int)Status.TestStatus.Work) DataBase.GetData($"UPDATE [dbo].[Tests] SET [idStatus] = '{(int)Status.TestStatus.Fail}' WHERE [idTest] = '{idTest}'");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            serialPort?.Close();
        }
    }
}
