using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (dgvOrders.SelectedRows.Count > 0)
            {
                dgvTests.DataSource = DataBase.GetData(
                    "SELECT Tests.idTest, Tests.numLoad, Compounds.nameCompound, TestProgramm.name, Status.description " +
                    "FROM Tests " +
                    "INNER JOIN Compounds ON Tests.idCompound = Compounds.idCompound " +
                    "INNER JOIN TestProgramm ON Tests.idProgramm = TestProgramm.idProgramm AND Compounds.idParameters = TestProgramm.idProgramm " +
                    "INNER JOIN Status ON Tests.idStatus = Status.idStatus WHERE (Tests.idOrder = '" + dgvOrders.SelectedRows[0].Cells["ColIdOrder"].Value?.ToString() + "')");
            }
        }
    }
}
