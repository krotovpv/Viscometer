using System;
using System.Data;
using System.Windows.Forms;

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

            loadOrders();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            loadOrders();
        }

        private void loadOrders()
        {
            dgvOrders.DataSource = DataBase.GetData(
                    "Select Orders.idOrder, Orders.numOrder, Orders.dateOrder, Testers.nameTester, Subdivisions.nameSubdiv AS subCustomer " +
                    "FROM Orders " +
                    "JOIN Testers ON Orders.idTester = Testers.idTester " +
                    "JOIN Subdivisions ON Orders.idSubdivisionCustomer = Subdivisions.idSubdiv");
            /*
            if (Tester.Right == Tester.Rights.AllSub)
            {
                dgvOrders.DataSource = DataBase.GetData(
                    "Select Orders.idOrder, Orders.numOrder, Orders.dateOrder, Testers.nameTester, Subdivisions.nameSubdiv AS subCustomer " +
                    "FROM Orders " +
                    "JOIN Testers ON Orders.idTester = Testers.idTester " +
                    "JOIN Subdivisions ON Orders.idSubdivisionCustomer = Subdivisions.idSubdiv");
            }
            else if (Tester.Right == Tester.Rights.MySub)
            {
                dgvOrders.DataSource = DataBase.GetData(
                    "Select Orders.idOrder, Orders.numOrder, Orders.dateOrder, Testers.nameTester, Subdivisions.nameSubdiv AS subCustomer " +
                    "FROM Orders " +
                    "JOIN Testers ON Orders.idTester = Testers.idTester " +
                    "JOIN Subdivisions ON Orders.idSubdivisionCustomer = Subdivisions.idSubdiv " +
                    $"WHERE Orders.idSubdivisionCustomer = '{Tester.IdSub}'");
            }
            else if (Tester.Right == Tester.Rights.MyOrders)
            {
                dgvOrders.DataSource = DataBase.GetData(
                    "Select Orders.idOrder, Orders.numOrder, Orders.dateOrder, Testers.nameTester, Subdivisions.nameSubdiv AS subCustomer " +
                    "FROM Orders " +
                    "JOIN Testers ON Orders.idTester = Testers.idTester " +
                    "JOIN Subdivisions ON Orders.idSubdivisionCustomer = Subdivisions.idSubdiv " +
                    $"WHERE Orders.idTester = '{Tester.Id}'");
            }
            */
        }

        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            loadTests();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count < 1) { MessageBox.Show("Выберите заказ!"); return; }
            if (dgvTests.SelectedRows.Count < 1) { MessageBox.Show("Выберите испытание!"); return; }

            int status = Convert.ToInt16(DataBase.GetData($"SELECT idStatus FROM [dbo].[Tests] WHERE idTest = '{dgvTests.SelectedRows[0].Cells["ColIdTest"].Value}'").Rows[0]["idStatus"]);
            if (status == (int)Status.TestStatus.Blank)
                new WorkForm(dgvTests.SelectedRows[0].Cells["ColIdTest"].Value.ToString(), true).Show();
            else
                MessageBox.Show("Данное испытание уже проводилось.", "Испытание");
        }

        private void btnAddTest_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows[0].Index < 0)
            {
                MessageBox.Show("Выберите заказ!"); return;
            }

            new AddTestForm(dgvOrders.SelectedRows[0].Cells["ColIdOrder"].Value.ToString()).ShowDialog();

            loadTests();
        }

        private void btnDelTest_Click(object sender, EventArgs e)
        {
            if (dgvTests.SelectedRows[0].Index < 0)
            {
                MessageBox.Show("Выберите испытание!", "Удаление"); return;
            }

            int status = Convert.ToInt16(DataBase.GetData($"SELECT idStatus FROM [dbo].[Tests] WHERE idTest = '{dgvTests.SelectedRows[0].Cells["ColIdTest"].Value}'").Rows[0]["idStatus"]);
            if (status == (int)Status.TestStatus.Handshake)
            {
                MessageBox.Show("Принятые испытания защищены от удаления!", "Удаление"); return;
            }
            if (status == (int)Status.TestStatus.Work)
            {
                MessageBox.Show("Данное испытание в работе!\n\nЕсли все же намерены удалить, необходимо убедится что испытание не запущено на одном из стендов. Если оно не запущено, смените статус испытания и попробуйте удалить.", "Удаление"); return;
            }

            if (MessageBox.Show("Вы уверены что желаете удалить испытание?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                DataBase.GetData($"DELETE FROM [dbo].[Tests] WHERE idTest = '{dgvTests.SelectedRows[0].Cells["ColIdTest"].Value}'");
            
            loadTests();
        }

        private void btnDelOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count < 1)
            {
                MessageBox.Show("Выберите заказ!"); return;
            }

            if (MessageBox.Show("Вы уверены что желаете удалить заказ?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                DataBase.GetData($"DELETE FROM [dbo].[Orders] WHERE idOrder = '{dgvOrders.SelectedRows[0].Cells["ColIdOrder"].Value}'");

            loadOrders();
        }

        private void btnReceiptTest_Click(object sender, EventArgs e)
        {
            if (dgvTests.SelectedRows.Count < 1)
            {
                MessageBox.Show("Выберите испытание!"); return;
            }

            DataRow row = DataBase.GetData($"Select * From Tests Where idTest = '{dgvTests.SelectedRows[0].Cells["ColIdTest"].Value}'").Rows[0];
            if (Convert.ToInt16(row["idStatus"]) == (int)Status.TestStatus.Blank) 
            {
                MessageBox.Show("Испытание еще не проводилось!"); return;
            }

            DataBase.GetData($"UPDATE [dbo].[Tests] SET [idStatus] = '{(int)Status.TestStatus.Handshake}' WHERE idTest = '{row["idTest"]}'");

            loadTests();
        }

        private void btnRejectTest_Click(object sender, EventArgs e)
        {
            if (dgvTests.SelectedRows.Count < 1)
            {
                MessageBox.Show("Выберите испытание!");
                return;
            }

            DataRow row = DataBase.GetData($"Select * From Tests Where idTest = '{dgvTests.SelectedRows[0].Cells["ColIdTest"].Value}'").Rows[0];
            if (Convert.ToInt16(row["idStatus"]) == (int)Status.TestStatus.Blank)
            {
                MessageBox.Show("Испытание еще не проводилось!"); return;
            }

            DataBase.GetData($"UPDATE [dbo].[Tests] SET [idStatus] = '{(int)Status.TestStatus.Ignor}' WHERE idTest = '{row["idTest"]}'");

            loadTests();
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
                    "SELECT Tests.idTest, Tests.numLoad, Compounds.nameCompound, Tests.loadProgramm, Status.shortDescription " +
                    "FROM Tests " +
                    "INNER JOIN Compounds ON Tests.idCompound = Compounds.idCompound " +
                    $"INNER JOIN Status ON Tests.idStatus = Status.idStatus WHERE Tests.idOrder = '{dgvOrders.SelectedRows[0].Cells["ColIdOrder"].Value?.ToString()}'");
            }
        }

        private void btnChartTest_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count < 1) { MessageBox.Show("Выберите заказ!"); return; }
            if (dgvTests.SelectedRows.Count < 1) { MessageBox.Show("Выберите испытание!"); return; }

            new WorkForm(dgvTests.SelectedRows[0].Cells["ColIdTest"].Value.ToString(), false).Show();
        }

        private void btnMaterials_Click(object sender, EventArgs e)
        {
            new MaterialsForm().Show();
        }
    }
}
