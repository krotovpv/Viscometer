using System;
using System.Drawing;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using Viscometer.Response;

namespace Viscometer
{
    public partial class SetProgrammForm : Form
    {
        public string TestPragrammString = "-";
        SerialPort _serialPort;
        string dataTail = string.Empty;
        string lastCommandPrefix = string.Empty;
        bool lsatCommandIsSuccess = false;
        bool ResponseSuccessA0 = false;
        bool ResponseSuccessA1 = false;
        bool ResponseSuccessA2 = false;
        bool ResponseSuccessA3 = false;
        bool ResponseSuccessA22 = false;
        bool ResponseSuccessA23 = false;
        bool ResponseSuccessA24 = false;
        int maxTryRequest = 3;

        public SetProgrammForm(SerialPort serialPort)
        {
            InitializeComponent();
            _serialPort = serialPort;
        }

        private void SetProgrammForm_Load(object sender, EventArgs e)
        {
            _serialPort.DataReceived += _serialPort_DataReceived;
        }

        private void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataTail += ((SerialPort)sender).ReadExisting();

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
            if (response.GetType() == typeof(ParameterResponse))
            {
                ParameterResponse res = response as ParameterResponse;
                if (res.State == ParameterResponse.EState.Success)
                {
                    switch (res.ResponseCode)
                    {
                        case "0":
                            ResponseSuccessA0 = true;
                            this.InvokeEx(() => { lblLinkSetTime.BackColor = Color.LightGreen; });
                            break;
                        case "1": 
                            ResponseSuccessA1 = true;
                            this.InvokeEx(() => { lblLinkTempTest.BackColor = Color.LightGreen; });
                            break;
                        case "2":
                            ResponseSuccessA2 = true;
                            this.InvokeEx(() => { lblLinkPreheatTime.BackColor = Color.LightGreen; });
                            break;
                        case "3":
                            ResponseSuccessA3 = true;
                            this.InvokeEx(() => { lblLinkDecay.BackColor = Color.LightGreen; });
                            break;
                        case "22":
                            ResponseSuccessA22 = true;
                            this.InvokeEx(() => { lblLinkRotorSize.BackColor = Color.LightGreen; });
                            break;
                        case "23":
                            ResponseSuccessA23 = true;
                            this.InvokeEx(() => { lblLinkTestType.BackColor = Color.LightGreen; });
                            break;
                        case "24":
                            ResponseSuccessA24 = true;
                            this.InvokeEx(() => { lblLinkPrintPreheat.BackColor = Color.LightGreen; });
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void radioBtnViscosity_Scorch_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnViscosity.Checked)
            {
                lblDecay.Enabled = true;
                dtpDecay.Enabled = true;
            }
            else if (radioBtnScorch.Checked)
            {
                lblDecay.Enabled = false;
                dtpDecay.Enabled = false;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //инициализация
            lblLinkDecay.BackColor = Color.LightCoral;
            lblLinkPreheatTime.BackColor = Color.LightCoral;
            lblLinkPrintPreheat.BackColor = Color.LightCoral;
            lblLinkRotorSize.BackColor = Color.LightCoral;
            lblLinkSetTime.BackColor = Color.LightCoral;
            lblLinkTempTest.BackColor = Color.LightCoral;
            lblLinkTestType.BackColor = Color.LightCoral;

            if (radioBtnViscosity.Checked)
            {
                TestPragrammString = "M";
                if (radioBtnRotorL.Checked) TestPragrammString += "L ";
                else if (radioBtnRotorS.Checked) TestPragrammString += "S ";
                TestPragrammString += dtpPreheat.Value.Minute.ToString() + "+";
                TestPragrammString += dtpTimeTest.Value.Minute.ToString();
                TestPragrammString += " (" + nudTemperature.Value.ToString().Replace(",", ".") + "°C)";
                if (dtpDecay.Value.Minute > 0) TestPragrammString += $" {dtpDecay.Value.Minute.ToString()}мин SR";
            }
            else if (radioBtnScorch.Checked)
            {
                TestPragrammString = "Scorch Δt = ";
                if (radioBtnRotorL.Checked) TestPragrammString += "t35 - t5";
                else if (radioBtnRotorS.Checked) TestPragrammString += "t18 - t3";
            }

            int loop = 0;
            while (loop < maxTryRequest)
            {
                if (!ResponseSuccessA0)
                {
                    //A 0 Время испытания
                    sentMsg($"A 0 {dtpPreheat.Value.Minute.ToString("D3")}:{dtpPreheat.Value.Second.ToString("D2")}.{dtpPreheat.Value.Millisecond.ToString("D1")}");
                }
                if (!ResponseSuccessA1)
                {
                    //A 1 Температура
                    sentMsg($"A 1 {nudTemperature.Value.ToString().Replace(",", ".")}");
                }
                if (!ResponseSuccessA2)
                {
                    //A 2 Время прогрева образца
                    sentMsg($"A 2 {dtpTimeTest.Value.Minute.ToString("D3")}:{dtpTimeTest.Value.Second.ToString("D2")}.{dtpTimeTest.Value.Millisecond.ToString("D1")}");
                }
                if (!ResponseSuccessA3)
                {
                    //A 3 релоксация (проводится только при испытании на вязкость)
                    if (radioBtnViscosity.Checked) sentMsg($"A 3 {dtpDecay.Value.Minute.ToString("D3")}:{dtpDecay.Value.Second.ToString("D2")}.{dtpDecay.Value.Millisecond.ToString("D1")}");
                }
                if (!ResponseSuccessA22)
                {
                    //A 22 Размер ротора
                    if (radioBtnRotorL.Checked) sentMsg("A 22 1");
                    else if (radioBtnRotorS.Checked) sentMsg("A 22 0");
                }
                if (!ResponseSuccessA23)
                {
                    //A 23 Тип испытания
                    if (radioBtnViscosity.Checked) sentMsg("A 23 1");
                    else if (radioBtnScorch.Checked) sentMsg("A 23 0");
                }
                if (!ResponseSuccessA24)
                {
                    //A 24 1-передавать данные при прогревве 0-отключить данные про прогреве
                    sentMsg("A 24 1");
                }
                Thread.Sleep(200);
                if (!ResponseSuccessA0 || !ResponseSuccessA1 || !ResponseSuccessA2 || !ResponseSuccessA3 ||
                    !ResponseSuccessA22 || !ResponseSuccessA23 || !ResponseSuccessA24)
                    loop++;
                else
                    loop = maxTryRequest;
            }

            if (ResponseSuccessA0 && ResponseSuccessA1 && ResponseSuccessA2 && ResponseSuccessA3 &&
                ResponseSuccessA22 && ResponseSuccessA23 && ResponseSuccessA24)
                this.DialogResult = DialogResult.OK;
            else
                btnOk.Text = "Повторить";
        }

        private void sentMsg(string msg)
        {
            char[] arr = msg.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                try
                {
                    _serialPort.Write(arr, i, 1);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    this.DialogResult = DialogResult.Cancel;
                }
                Thread.Sleep(10);
            }
            _serialPort.Write("\r");
            Thread.Sleep(100);
        }

        private void SetProgrammForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _serialPort.DataReceived -= _serialPort_DataReceived;
        }
    }
}
