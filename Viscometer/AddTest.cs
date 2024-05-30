using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Viscometer
{
    public partial class AddTest : Form
    {
        int OrderIndex = -1;
        public AddTest(int orderIndex)
        {
            InitializeComponent();

            OrderIndex = orderIndex;
        }

        private void AddTest_Load(object sender, EventArgs e)
        {
            if (OrderIndex == -1) this.Close();

            lblOrderNumber.Text = DataBase.GetData($"Select numOrder From Orders WHERE idOrder = {OrderIndex}").Rows[0].ItemArray[0].ToString();
            nudLoadNumber.Value = DataBase.GetData($"Select * From Tests WHERE idOrder = {OrderIndex}").Rows.Count + 1;
        }
    }
}