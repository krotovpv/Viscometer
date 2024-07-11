using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
        string idTest = string.Empty;
        
        public WorkForm(string IdTest)
        {
            InitializeComponent();

            idTest = IdTest;
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

            //получить программу испытания и залить в вискозиметр, если не выйдет выдать сообщение и закрыться
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
            DataBase.GetData($"INSERT INTO [dbo].[ProcessLink] ([idTest],[stringFromStand]) VALUES ('{idTest}' ,'{line}')");

            txtData.InvokeEx(() => 
            {
                txtData.AppendText(line + Environment.NewLine);
                txtData.SelectionStart = txtData.Text.Length;
                txtData.ScrollToCaret();
            });

            //A - Ответ стенда при получении комынды
            //S - Start, начальная запись перед процессом испытания
            //L - Текущие данные, получаемые в процессе испытания
            //E - End, завершающая строка с результатами испытания
            switch (line[0])
            {
                case 'A':
                    ParseA(line); break;
                case 'S':
                    ParseS(line); break;
                case 'L':
                    ParseL(line); break;
                case 'E':
                    ParseE(line); break;
                default:
                    break;
            }

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

        /// <summary>
        /// Разбор сообщение о принятой команде
        /// </summary>
        /// <param name="responce">Сообщение от стенда</param>
        private bool ParseA(string[] responce)
        {
            
        }


        /// <summary>
        /// Разбор сообщения о начале испытания
        /// </summary>
        /// <param name="responce">Сообщение от стенда</param>
        /// <returns>Успешно ли получено сообщение</returns>
        private bool ParseS(string responce)
        {
            DataBase.GetData("UPDATE [dbo].[Tests] " +
                "SET " +
                    "[dateStartTest] = CURRENT_TIMESTAMP, " +
                    $"[startString] = '{responce}' " +
                "WHERE " +
                    $"[idTest] = '{idTest}'");

            string[] arr = responce.Split(',');

            if (arr.Length < 6) return false;

            if (arr[0][1] == 'S')
            {
                //Испытание типа Scorch
            }
            else if (arr[0][1] == 'V')
            {
                //Испытание типа Viscosity
            }
            else
            {
                return false;
            }

            if (arr[0][3] == 'S')
            {
                //Испытание с Small ротором
            }
            else if (arr[0][3] == 'L')
            {
                //Испытание с Large ротором
            }
            else
            {
                return false;
            }

            //A - температура заданная (Set point)
            //B - Установленое время для испытания (Set Time)
            //C - Время подогрева (прогрев) (Preheat)
            //D - Релоксация (Decay)
            //E - (Visc range)
            //F - Заводской номер (Factory Number)
            for (int i = 1; i < arr.Length; i++)
            {
                switch (arr[i][0])
                {
                    case 'A': 
                        break;
                    case 'B':
                        break;
                    case 'C':
                        break;
                    case 'D':
                        break;
                    case 'E':
                        break;
                    case 'F':
                        break;
                    default:
                        break;
                }
            }
            return true;
        }

        /// <summary>
        /// Разбор сообщения о текущщих данных испытания
        /// </summary>
        /// <param name="responce">Сообщение от стенда</param>
        private bool ParseL(string responce)
        {

        }

        /// <summary>
        /// Разбор сообщения о завершении испытания
        /// </summary>
        /// <param name="responce">Сообщение от стенда</param>
        private bool ParseE(string[] responce)
        {

        }

        private void WorkForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort?.Close();
        }
    }
}
