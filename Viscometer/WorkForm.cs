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

        public WorkForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (SelectViscometerForm svForm = new SelectViscometerForm())
            {
                if (svForm.ShowDialog() == DialogResult.OK)
                    portName = svForm.SelectPortName;
                else
                    this.Close();

                MessageBox.Show($"Select{portName}");
            }

            try
            {
                SerialPort serialPort = new SerialPort(portName);
                serialPort.DataReceived += SerialPort_DataReceived;
                serialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
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
                    ParseLine(line);
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
                lblResult.InvokeEx(() =>
                    lblResult.Text = $"{arr[1]}, {arr[2]}, {arr[3]}, {arr[4]}, {arr[5]}");
            }
        }
    }
}
