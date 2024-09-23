using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Viscometer
{
    public partial class AddOrderForm : Form
    {
        public AddOrderForm()
        {
            InitializeComponent();
        }

        private void AddOrderForm_Load(object sender, EventArgs e)
        {
            DataTable dtSub = DataBase.GetData("SELECT [nameSubdiv] FROM [Subdivisions]");
            for (int i = 0; i < dtSub.Rows.Count; i++)
                cbSubdivisionCustomer.Items.Add(dtSub.Rows[i].Field<string>("nameSubdiv"));
            cbSubdivisionCustomer.SelectedItem = Tester.NameSub;

            Secure();
        }

        private void Secure()
        {
            if (Tester.Right == Tester.Rights.MyOrders)
            {
                cbTester.Enabled = false;

                cbTester.Items.Add(Tester.Name);
                cbTester.SelectedItem = Tester.Name;
            }
            else if (Tester.Right == Tester.Rights.MySub)
            {
                cbTester.Enabled = true;

                DataTable dtTesters = DataBase.GetData($"SELECT [nameTester] FROM [Testers] WHERE [idTester] = '{Tester.Id}'");
                for (int i = 0; i < dtTesters.Rows.Count; i++)
                    cbTester.Items.Add(dtTesters.Rows[i].Field<string>("nameTester"));
                cbTester.SelectedItem = Tester.Name;
            }
            else if (Tester.Right == Tester.Rights.AllSub)
            {
                cbTester.Enabled = true;

                DataTable dtTesters = DataBase.GetData("SELECT [nameTester] FROM [Testers]");
                for (int i = 0; i < dtTesters.Rows.Count; i++)
                    cbTester.Items.Add(dtTesters.Rows[i].Field<string>("nameTester"));
                cbTester.SelectedItem = Tester.Name;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtNumOrder.Text.Trim().Length < 1)
            {
                MessageBox.Show("Укажите номер заказа!", "Внимание");
                return;
            }
            DataBase.GetData(
                "INSERT INTO [dbo].[Orders] ([numOrder],[dateOrder],[idTester],[idSubdivisionCustomer])" +
                "VALUES(" +
                    $"'{txtNumOrder.Text.Trim()}'," +
                    $"'{dtpDate.Value}'," +
                    $"(SELECT [idTester] FROM [Testers] WHERE [nameTester] = '{cbTester.SelectedItem}')," +
                    $"(SELECT [idSubdiv] FROM [Subdivisions] WHERE [nameSubdiv] = '{cbSubdivisionCustomer.SelectedItem}')" +
                ")");

            this.Close();
        }

        private void txtNumOrder_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsDigit(e.KeyChar)) e.Handled = true;
        }
    }
}
