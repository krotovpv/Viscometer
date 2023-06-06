using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Viscometer
{
    public partial class AddViscometerForm : Form
    {
        public string[] PortNames { get; set; } = SerialPort.GetPortNames();
        public Viscometer Viscometer { get; private set; }

        public AddViscometerForm()
        {
            InitializeComponent();
        }

        private void AddViscometerForm_Load(object sender, EventArgs e)
        {
            cbPortName.Items.Clear();
            cbPortName.Items.AddRange(PortNames);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Viscometer = new Viscometer(txtName.Text.Replace(",", "").Trim(), cbPortName.Text.Trim());
        }
    }
}
