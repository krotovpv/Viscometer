using System;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using Viscometer.Response;
using Viscometer.TestObject;

namespace Viscometer
{
    public partial class WorkForm : Form
    {
        string dataTail = string.Empty;
        SerialPort _serialPort = null;
        int tempIdTest;
        bool tempIsArchive;
        Test _Test;

        public WorkForm(int idTest, bool isArchive = false)
        {
            InitializeComponent();

            tempIdTest = idTest;
            tempIsArchive = isArchive;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _Test = new Test(tempIdTest);
            _Test.IsArchive = tempIsArchive;

            if (_Test.IsArchive)
            {
                LoadArchiveTest();
            }
            else
            {
                if (!LoadNewTest())
                {
                    this.Close(); return;
                }
            }

            FillUI();
            this.WindowState = FormWindowState.Maximized;
        }

        private void FillUI()
        {
            if (!_Test.IsArchive)
                ClearUI();

            this.InvokeEx(() =>
            {
                lblStartTime.Text = _Test.DateStartTest.ToString();
                lblLoad.Text = _Test.NumLoad.ToString();
                lblOrder.Text = _Test.NumOrder;
                lblCompound.Text = _Test.NameCompound;

                if (_Test.LoadedProgram == null)
                {
                    lblTestTime.Text = "Время испытания: -";
                    lblPreheat.Text = "Время прогрева: -";
                    lblTemperature.Text = "Температура: -";
                    lblRelax.Text = "Время релаксации: -";
                }
                else
                {
                    lblTestTime.Text = "Время испытания: " + _Test.LoadedProgram.SetTime.ToString();
                    lblPreheat.Text = "Время прогрева: " + _Test.LoadedProgram.Preheat.ToString();
                    lblTemperature.Text = "Температура: " + _Test.LoadedProgram.SetPoint.ToString();
                    lblRelax.Text = "Время релаксации: " + _Test.LoadedProgram.Decay.ToString();
                }
                lblNum.Text = "Номер: " + _Test.FactoryNumStand;

                if (_Test.Type == Test.EType.Viscosity)
                {
                    if (_Test.LoadedProgram != null && _Test.LoadedProgram.Decay.TotalSeconds > 0)
                        lblType.Text = "Тип: Вязкость и релоксация (Viscosity + SR)";
                    else
                        lblType.Text = "Тип: Вязкость (Viscosity)";
                }
                else
                {
                    lblType.Text = "Тип: Подвулканизация (Scorch)";
                }
            });
        }

        private void ClearUI()
        {
            this.InvokeEx(() =>
            {
                lblStartTime.Text = "-";
                lblLoad.Text = "-";
                lblOrder.Text = "-";
                lblCompound.Text = "-";
                lblTestTime.Text = "Время испытания: -";
                lblPreheat.Text = "Время прогрева: -";
                lblTemperature.Text = "Температура: -";
                lblRelax.Text = "Время релаксации: -";
                txtData.Text = "";
                lblResault.Text = "-";
                lblResault.BackColor = Color.White;
                chartValue.Series[0].Points.Clear();
                chartTemperature.Series[0].Points.Clear();
                chartTemperature.Series[1].Points.Clear();
            });
        }

        private bool LoadNewTest()
        {
            //Выбираем стенд
            using (SelectViscometerForm svForm = new SelectViscometerForm())
            {
                if (svForm.ShowDialog() == DialogResult.OK)
                {
                    this.Text = svForm.SelectedPortName;
                    if (svForm.SelectedPortName == String.Empty) return false;

                    try
                    {
                        _serialPort = new SerialPort(svForm.SelectedPortName);
                        _serialPort.Open();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            _serialPort.DataReceived += SerialPort_DataReceived;
            return true;
        }

        private void LoadArchiveTest()
        {
            this.Text = "Просмотр результатов испытания";
            this.BackColor = Color.Moccasin;
            DataTable dt = _Test.GetArchiveData();
            foreach (DataRow item in dt.Rows)
            {
                ParseLine(item[0].ToString());
            }
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

            IResponseOfStand response = ResponseOfStand.Parse(line);
            if (response.GetType() == typeof(CurrentResponse))
            {
                CurrentResponse currentResponse = response as CurrentResponse;
                this.InvokeEx(() =>
                {
                    chartValue.Series[0].Points.Add(currentResponse.Viscosity);
                    chartTemperature.Series[0].Points.Add(currentResponse.TemperatureUp);
                    chartTemperature.Series[1].Points.Add(currentResponse.TemperatureDown);
                });
            }
            else if(response.GetType() == typeof(StartResponse))
            {
                StartResponse startResponse = response as StartResponse;
                _Test.SetStartResponse(startResponse);
                if (_Test.IsArchive)
                    this.InvokeEx(() => Text += " - " + startResponse.FactoryNumber);
                else
                    this.InvokeEx(() => Text = startResponse.FactoryNumber);
                FillUI();
            }
            else if (response.GetType() == typeof(EndResponse))
            {
                EndResponse endResponse = response as EndResponse;
                _Test.SetEndResponse(endResponse);
                if (endResponse.Status == 1)
                {
                    this.InvokeEx(() => 
                    {
                        lblResault.Text = "Успешно";
                        lblResault.BackColor = Color.LightGreen;
                        string testResult = string.Empty;
                        if (_Test.Type == Test.EType.Viscosity)
                            testResult = "MU " + endResponse.FinalViscosity.ToString();
                        else if (_Test.Type == Test.EType.Scorch)
                        {
                            if (_Test.RotorSize == RotorType.Large)
                                testResult = $"Δt ({endResponse.T18orT35 - endResponse.T3orT5}) = t35 ({endResponse.T18orT35.ToString()}) - t5 ({endResponse.T3orT5.ToString()})";
                            else if (_Test.RotorSize == RotorType.Small)
                                testResult = $"Δt ({endResponse.T18orT35 - endResponse.T3orT5}) = t18 ({endResponse.T18orT35.ToString()}) - t3 ({endResponse.T3orT5.ToString()})";
                        }
                        _Test.SetTestResult(testResult);
                        lblResault.Text = testResult;
                    });
                }
                else if (endResponse.Status == 2)
                {
                    this.InvokeEx(() =>
                    {
                        lblResault.Text = "Провалено";
                        lblResault.BackColor = Color.LightCoral;
                    });
                }
            }

            _Test.SaveResponse(line);

            txtData.InvokeEx(() =>
            {
                txtData.AppendText(line + Environment.NewLine);
                txtData.SelectionStart = txtData.Text.Length;
                txtData.ScrollToCaret();
            });
        }

        private void WorkForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Test.SetBreakTest();

            _serialPort?.Close();
        }
    }
}
