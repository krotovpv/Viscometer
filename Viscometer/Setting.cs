﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Viscometer
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void btnSaveDbName_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DbName = txtDbName.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("Перезапустите приложение!");
            this.Close();
        }
    }
}
