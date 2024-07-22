using System;
using System.Data;
using System.IO.Ports;
using System.Windows.Forms;
using Viscometer.Response;

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
        string numOrder = string.Empty;
        string nameCompound;
        
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
                    portName = svForm.SelectPortName;
                else
                    this.Close();

                this.Text = portName;
            }

            try
            {
                if (portName == string.Empty) this.Close();
                serialPort = new SerialPort(portName);
                serialPort.DataReceived += SerialPort_DataReceived;
                serialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }

            //!!! Задать программу испытания и проверить что она загружена! Если не выйдет выдать сообщение и закрыться

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
                
            }
            else if (response.GetType() == typeof(EndResponse))
            {

            }
            else if (response.GetType() == typeof (CurrentResponse))
            {

            }
        }

        private void WorkForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort?.Close();
        }
    }
}
