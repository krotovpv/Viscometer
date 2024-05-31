using System;
using System.Data;
using System.Windows.Forms;

namespace Viscometer
{
    public partial class AddTest : Form
    {
        string orderId = "";

        public AddTest(string OrderId)
        {
            InitializeComponent();

            orderId = OrderId;
        }

        private void AddTest_Load(object sender, EventArgs e)
        {
            if (orderId == "") this.Close();

            lblOrderNumber.Text = DataBase.GetData($"Select numOrder From Orders WHERE idOrder = '{orderId}'").Rows[0].ItemArray[0].ToString();
            nudLoadNumber.Value = DataBase.GetData($"Select * From Tests WHERE idOrder = '{orderId}'").Rows.Count + 1;

            DataTable dtProgramm = DataBase.GetData("Select idProgramm, name From TestProgramm");
            cbProgramm.DataSource = dtProgramm;
            cbProgramm.ValueMember = "idProgramm";
            cbProgramm.DisplayMember = "name";

            DataTable dtCompound = DataBase.GetData("Select idCompound, nameCompound From Compounds");
            cbCompound.DataSource = dtCompound;
            cbCompound.ValueMember = "idCompound";
            cbCompound.DisplayMember = "nameCompound";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DataBase.GetData("INSERT INTO [dbo].[Tests] ([idOrder],[idProgramm],[idCompound],[numLoad]) " +
                $"VALUES ('{orderId}','{cbProgramm.SelectedValue}','{cbCompound.SelectedValue}','{nudLoadNumber.Value}')");

            this.Close();
        }
    }
}