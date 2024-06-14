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
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            DataTable dtSub = DataBase.GetData("SELECT [nameSubdiv] FROM [Subdivisions]");
            cbSub.Items.Add("ВСЕ");
            for (int i = 0; i < dtSub.Rows.Count; i++)
                cbSub.Items.Add(dtSub.Rows[i].Field<string>("nameSubdiv"));
            cbSub.SelectedIndex = 0;
            cbSub.SelectedIndexChanged += CbSub_SelectedIndexChanged;
            CbSub_SelectedIndexChanged(null, null);
        }

        private void CbSub_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbName.Items.Clear();
            DataTable dtTesters = null;
            if (cbSub.Text == "ВСЕ")
                dtTesters = DataBase.GetData("SELECT [nameTester] FROM [Testers]");
            else
                dtTesters = DataBase.GetData("SELECT [nameTester] FROM [Testers] WHERE [idSubdiv] = (SELECT [idSubdiv] FROM [Subdivisions] WHERE [nameSubdiv] = '" + cbSub.SelectedItem + "')");

            if (dtTesters != null)
                for (int i = 0; i < dtTesters.Rows.Count; i++)
                    cbName.Items.Add(dtTesters.Rows[i].Field<string>("nameTester"));
        }

        private void CheckAutorization()
        {
            if (Tester.Authorization(cbName.Text.Trim(), maskedTxtPassword.Text.Trim()))
                this.Close();
            else
                MessageBox.Show("Не верно указано Имя или Пароль.");
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            CheckAutorization();
        }

        private void cbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                CheckAutorization();
            }    
                
        }

        private void maskedTxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                CheckAutorization();
            }
        }

        private void linkLblSetting_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Setting().ShowDialog();
        }
    }
}
