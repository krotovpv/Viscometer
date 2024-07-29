using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace Viscometer
{
    public partial class SetProgramm : Form
    {
        public string TestPragrammString = "-";
        SerialPort _serialPort;
        public SetProgramm(SerialPort serialPort)
        {
            InitializeComponent();
            _serialPort = serialPort;
        }

        private void SetProgramm_Load(object sender, EventArgs e)
        {

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

            try
            {
                //A 0 Время испытания
                sentMsg($"A 0 {dtpPreheat.Value.Minute.ToString("D3")}:{dtpPreheat.Value.Second.ToString("D2")}.{dtpPreheat.Value.Millisecond.ToString("D1")}");
                //A 1 Температура
                sentMsg($"A 1 {nudTemperature.Value.ToString().Replace(",", ".")}");
                //A 2 Время прогрева образца
                sentMsg($"A 2 {dtpTimeTest.Value.Minute.ToString("D3")}:{dtpTimeTest.Value.Second.ToString("D2")}.{dtpTimeTest.Value.Millisecond.ToString("D1")}");
                //A 3 релоксация (проводится только при испытании на вязкость)
                if (radioBtnViscosity.Checked) sentMsg($"A 2 {dtpDecay.Value.Minute.ToString("D3")}:{dtpDecay.Value.Second.ToString("D2")}.{dtpDecay.Value.Millisecond.ToString("D1")}");
                //A 22 Размер ротора
                if (radioBtnRotorL.Checked) sentMsg("A 22 1");
                else if (radioBtnRotorS.Checked) sentMsg("A 22 0");
                //A 23 Тип испытания
                if (radioBtnViscosity.Checked) sentMsg("A 23 1");
                else if (radioBtnScorch.Checked) sentMsg("A 23 0");
                //A 24 1-передавать данные при прогревве 0-отключить данные про прогреве
                sentMsg("A 24 1");
            }
            catch (Exception)
            {
                this.DialogResult = DialogResult.Cancel;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void sentMsg(string msg)
        {
            char[] arr = msg.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                _serialPort.Write(arr, i, 1);
                Thread.Sleep(10);
            }
            Thread.Sleep(100);
        }
    }
}
