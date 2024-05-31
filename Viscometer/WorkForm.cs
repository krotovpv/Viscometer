using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viscometer
{
    public partial class WorkForm : Form
    {
        string portName = string.Empty;
        string dataTail = string.Empty;
        SerialPort serialPort = null;
        DataRow dataRowTest = null;
        DataRow dataRowProgramm = null;
        
        public WorkForm(string IdTest)
        {
            InitializeComponent();

            dataRowTest = DataBase.GetData($"SELECT * FROM [dbo].[Tests] WHERE idTest = '{IdTest}'").Rows[0];
            dataRowProgramm = DataBase.GetData($"SELECT * FROM [dbo].[TestProgramm] WHERE idProgramm = '{dataRowTest["idProgramm"]}'").Rows[0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (SelectViscometerForm svForm = new SelectViscometerForm())
            {
                if (svForm.ShowDialog() == DialogResult.OK)
                    portName = svForm.SelectPortName;
                else
                    this.Close();

                this.Text = portName;
            }

            try
            {
                if (portName == string.Empty) return;
                serialPort = new SerialPort(portName);
                serialPort.DataReceived += SerialPort_DataReceived;
                serialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }

            lblOrder.Text = DataBase.GetData($"SELECT numOrder FROM [dbo].[Orders] WHERE idOrder = '{dataRowTest["idOrder"]}'").Rows[0]["numOrder"].ToString();
            lblLoad.Text = dataRowTest["numLoad"].ToString();
            lblCompound.Text = DataBase.GetData($"SELECT nameCompound FROM [dbo].[Compounds] WHERE idCompound = '{dataRowTest["idCompound"]}'").Rows[0]["nameCompound"].ToString();
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
            //записываем строку в базу

            txtData.InvokeEx(() => 
            {
                txtData.AppendText(line + Environment.NewLine);
                txtData.SelectionStart = txtData.Text.Length;
                txtData.ScrollToCaret();
            });

            string[] arr = line.Split(',');
            if (arr[0] == "L" && arr[1][0] == 'a')
            {
                string[] timeArr = arr[1].Trim(' ', 'a').Split(':', '.');
                TimeSpan time = new TimeSpan(0, Convert.ToInt16(timeArr[0]), Convert.ToInt16(timeArr[1]));
                if (arr[2][0] == 'b')
                {
                    double value = Convert.ToDouble(arr[2].Replace('.', ',').Replace(" ", "").Replace("b", ""));

                    chartValue.InvokeEx(() =>
                        chartValue.Series[0].Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(time.TotalSeconds, value)));
                }
                if (arr[3][0] == 'd' && arr[4][0] == 'e')
                {
                    double valueD = Convert.ToDouble(arr[3].Replace('.', ',').Replace(" ", "").Replace("d", ""));
                    double valueE = Convert.ToDouble(arr[4].Replace('.', ',').Replace(" ", "").Replace("e", ""));

                    chartTemperature.InvokeEx(() => 
                    {
                        chartTemperature.Series[0].Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(time.TotalSeconds, valueD));
                        chartTemperature.Series[1].Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(time.TotalSeconds, valueE));
                    });
                }
            }
            else if (arr[0] == "SV1L")
            {
                foreach (var item in arr)
                {
                    if (item == "") continue;
                    switch (item[0])
                    {
                        case 'A':
                            lblTemperature.InvokeEx(() =>
                                lblTemperature.Text = "Температура: " + item.Remove(0, 1));
                            break;
                        case 'B':
                            lblTestTime.InvokeEx(() => 
                                lblTestTime.Text = "Время испытания: " + item.Remove(0, 1)); 
                            break;
                        case 'C':
                            lblPreheat.InvokeEx(() =>
                                lblPreheat.Text = "Время прогрева: " + item.Remove(0, 1));
                            break;
                        case 'D':
                            lblRelax.InvokeEx(() =>
                                lblRelax.Text = "Время релаксации: " + item.Remove(0, 1));
                            break;
                        case 'F':
                            lblNum.InvokeEx(() =>
                                lblNum.Text = "Номер: " + item.Remove(0, 1));
                            break;
                        default:
                            break;
                    }
                }
            }
            else if (arr[0][0] == 'E')
            {
                //отметить в БД что испытание завершено

                lblMoonyRes.InvokeEx(() =>
                    lblMoonyRes.Text = arr[1].Trim(' ', 'a'));
                lblTimeRes.InvokeEx(() =>
                    lblTimeRes.Text = arr[3].Trim(' ', 'f'));
                lblTemp1Res.InvokeEx(() =>
                    lblTemp1Res.Text = arr[2].Trim(' ', 'e'));
                lblTemp2Res.InvokeEx(() =>
                    lblTemp2Res.Text = arr[4].Trim(' ', 'p'));
            }
        }

        private void WorkForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort?.Close();
        }
    }
}
