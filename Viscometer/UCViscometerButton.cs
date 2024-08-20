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
    public partial class UCViscometerButton : UserControl
    {
        public UCViscometerButton(Viscometer viscometer)
        {
            InitializeComponent();

            lblName.Text = viscometer.Name;
            lblPortName.Text = viscometer.PortName;
            lblNumber.Text = viscometer.Number;
        }

        private void UCViscometerButton_Load(object sender, EventArgs e)
        {
            Click += UCViscometerButton_Click;
            foreach (Control item in Controls)
            {
                if (item.Name != "picBoxDel")
                    item.Click += UCViscometerButton_Click;
            }
            //проверить доступно ли устройство

        }

        private void UCViscometerButton_Click(object sender, EventArgs e)
        {
            BackColor = Color.LightGreen;
            FlowLayoutPanel flp = Parent as FlowLayoutPanel;
            SelectViscometerForm frm = flp.Parent as SelectViscometerForm;
            frm.SelectPortName = lblPortName.Text;
            frm.DialogResult = DialogResult.OK;
        }  

        private void picBoxDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно желаете удалить?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (var item in SaveSettings.Viscometers)
                {
                    if (item.PortName == this.lblPortName.Text)
                    {
                        SaveSettings.Viscometers.Remove(item);
                        break;
                    }
                }
                SaveSettings.Save();
                FlowLayoutPanel flp = Parent as FlowLayoutPanel;
                flp.Controls.Remove(this);
            }
        }
    }
}
