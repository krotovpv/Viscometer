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
    public partial class Form1 : Form
    {
        string dataTail = string.Empty;
        List<string> data = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                SerialPort serialPort = new SerialPort("COM3");
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
            Action act = () =>
            {
                txtData.AppendText(line + Environment.NewLine);
                txtData.SelectionStart = txtData.Text.Length;
                txtData.ScrollToCaret();
            };
            if (txtData.InvokeRequired)
                txtData.Invoke(act);
            else
                act();

            string[] arr = line.Split(',');
            if (arr.Length > 0)
            {
                if (arr[0] == "L" && arr[1][0] == 'a')
                {
                    string[] timeArr = arr[1].Trim(' ', 'a').Split(':', '.');
                    TimeSpan time = new TimeSpan(0, Convert.ToInt16(timeArr[0]), Convert.ToInt16(timeArr[1]));
                    if (arr[2][0] == 'b')
                    {
                        double value = Convert.ToDouble(arr[2].Replace('.', ',').Replace(" ", "").Replace("b", ""));

                        Action actChart = () => chartValue.Series[0].Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(time.TotalSeconds, value));
                        if (chartValue.InvokeRequired)
                            chartValue.Invoke(actChart);
                        else
                            actChart();
                    }
                    if (arr[3][0] == 'd' && arr[4][0] == 'e')
                    {
                        double valueD = Convert.ToDouble(arr[3].Replace('.', ',').Replace(" ", "").Replace("d", ""));
                        double valueE = Convert.ToDouble(arr[4].Replace('.', ',').Replace(" ", "").Replace("e", ""));

                        Action actChart = () =>
                        {
                            chartTemperature.Series[0].Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(time.TotalSeconds, valueD));
                            chartTemperature.Series[1].Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(time.TotalSeconds, valueE));
                        };
                        if (chartTemperature.InvokeRequired)
                            chartTemperature.Invoke(actChart);
                        else
                            actChart();
                    }
                }
            }
        }
    }
}
