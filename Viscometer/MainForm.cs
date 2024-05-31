using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Viscometer.Properties;

namespace Viscometer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
         
        private void MainForm_Load(object sender, EventArgs e)
        {
            new AuthorizationForm().ShowDialog();
            if (!Tester.IsAuthorization) this.Close();

            grpBoxTester.Text = Tester.NameSub;
            lblTester.Text = Tester.Name; 

            btnView_Click(null, null);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddOrderForm().ShowDialog();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            dgvOrders.DataSource = DataBase.GetData(
                "SELECT Orders.idOrder, Orders.numOrder, Orders.dateOrder, Testers.nameTester, Subdivisions.nameSubdiv " +
                "FROM Orders " +
                "INNER JOIN Testers ON Orders.idTester = Testers.idTester " +
                "INNER JOIN Subdivisions ON Orders.idSubdiv = Subdivisions.idSubdiv AND Testers.idSubdiv = Subdivisions.idSubdiv");
        }
         
        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            loadTests();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count < 1) { MessageBox.Show("Выберите заказ!"); return; }
            if (dgvTests.SelectedRows.Count < 1) { MessageBox.Show("Выберите испытание!"); return; }

            if (DataBase.GetData($"SELECT idStatus FROM [dbo].[Tests] WHERE idTest = '{dgvTests.SelectedRows[0].Cells["ColIdTest"].Value}'").Rows[0]["idStatus"].ToString() == "1")
                new WorkForm(dgvTests.SelectedRows[0].Cells["ColIdTest"].Value.ToString()).Show();
            else
                MessageBox.Show("Донное испытание уже проводилось.", "Испытание");
        }

        private void btnAddTest_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows[0].Index < 0)
            {
                MessageBox.Show("Выберите заказ!"); return;
            }

            new AddTest(dgvOrders.SelectedRows[0].Cells["ColIdOrder"].Value.ToString()).ShowDialog();
        }

        private void btnDelTest_Click(object sender, EventArgs e)
        {
            if (dgvTests.SelectedRows[0].Index < 0)
            {
                MessageBox.Show("Выберите испытание!", "Удаление"); return;
            }

            if (DataBase.GetData($"SELECT idStatus FROM [dbo].[Tests] WHERE idTest = '{dgvTests.SelectedRows[0].Cells["ColIdTest"].Value}'").Rows[0]["idStatus"].ToString() == "4")
            {
                MessageBox.Show("Принятые испытания защищены от удаления!", "Удаление"); return;
            }

            if (MessageBox.Show("Вы уверены что желаете удалить испытание?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                DataBase.GetData($"DELETE FROM [dbo].[Tests] WHERE idTest = '{dgvTests.SelectedRows[0].Cells["ColIdTest"].Value}'");
        }

        private void btnDelOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows[0].Index < 0)
            {
                MessageBox.Show("Выберите заказ!"); return;
            }

            if (MessageBox.Show("Вы уверены что желаете удалить заказ?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                DataBase.GetData($"DELETE FROM [dbo].[Orders] WHERE idOrder = '{dgvOrders.SelectedRows[0].Cells["ColIdOrder"].Value}'");
        }

        private void btnReceiptTest_Click(object sender, EventArgs e)
        {
            if (dgvTests.SelectedRows[0].Index < 0)
            {
                MessageBox.Show("Выберите испытание!"); return;
            }

            DataRow row = DataBase.GetData($"Select * From Tests Where idTest = '{dgvTests.SelectedRows[0].Cells["ColIdTest"].Value}'").Rows[0];
            if (row["idStatus"].ToString() == "1") 
            {
                MessageBox.Show("Испытание еще не проводилось!"); return;
            }

            DataBase.GetData($"UPDATE [dbo].[Tests] SET [idStatus] = '4' WHERE idTest = '{row["idTest"]}'");
        }

        private void btnRejectTest_Click(object sender, EventArgs e)
        {
            if (dgvTests.SelectedRows[0].Index < 0)
            {
                MessageBox.Show("Выберите испытание!");
                return;
            }

            DataRow row = DataBase.GetData($"Select * From Tests Where idTest = '{dgvTests.SelectedRows[0].Cells["ColIdTest"].Value}'").Rows[0];
            if (row["idStatus"].ToString() == "1")
            {
                MessageBox.Show("Испытание еще не проводилось!"); return;
            }

            DataBase.GetData($"UPDATE [dbo].[Tests] SET [idStatus] = '5' WHERE idTest = '{row["idTest"]}'");
        }

        private void btnViewTest_Click(object sender, EventArgs e)
        {
            loadTests();
        }

        private void loadTests()
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                dgvTests.DataSource = DataBase.GetData(
                    "SELECT Tests.idTest, Tests.numLoad, Compounds.nameCompound, TestProgramm.name, Status.short_description " +
                    "FROM Tests " +
                    "INNER JOIN Compounds ON Tests.idCompound = Compounds.idCompound " +
                    "INNER JOIN TestProgramm ON Tests.idProgramm = TestProgramm.idProgramm AND Compounds.idParameters = TestProgramm.idProgramm " +
                    "INNER JOIN Status ON Tests.idStatus = Status.idStatus WHERE (Tests.idOrder = '" + dgvOrders.SelectedRows[0].Cells["ColIdOrder"].Value?.ToString() + "')");
            }
        }
    }
}
