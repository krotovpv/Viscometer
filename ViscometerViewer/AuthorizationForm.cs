using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ViscometerViewer
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            DataTable dt = DataBase.GetData("SELECT [nameTester] FROM [Testers]");
            for (int i = 0; i < dt.Rows.Count; i++)
                cbName.Items.Add(dt.Rows[i].Field<string>("nameTester"));
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
                CheckAutorization();
        }

        private void maskedTxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                CheckAutorization();
        }

    }
}
