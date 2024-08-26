using System;
using System.Data;
using System.Windows.Forms;

namespace Viscometer
{
    public partial class AddTestForm : Form
    {
        string orderId = "";

        public AddTestForm(string OrderId)
        {
            InitializeComponent();

            orderId = OrderId;
        }

        private void AddTestForm_Load(object sender, EventArgs e)
        {
            if (orderId == "") this.Close();

            lblOrderNumber.Text = DataBase.GetData($"Select numOrder From Orders WHERE idOrder = '{orderId}'").Rows[0].ItemArray[0].ToString();
            nudLoadNumber.Value = DataBase.GetData($"Select * From Tests WHERE idOrder = '{orderId}'").Rows.Count + 1;

            cbTypeCompound.DataSource = DataBase.GetData("SELECT [idTypeCompound],[nameTypeCompound] FROM [Viscosimeters].[dbo].[TypeOfCompound]");
            cbTypeCompound.ValueMember = "idTypeCompound";
            cbTypeCompound.DisplayMember = "nameTypeCompound";
            cbTypeCompound.SelectedIndexChanged += CbTypeCompound_SelectedIndexChanged;
            UpdateCompound();
        }

        private void CbTypeCompound_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCompound();
        }

        private void UpdateCompound()
        {
            cbCompound.DataSource = DataBase.GetData($"Select idCompound, nameCompound From Compounds WHERE idType = '{cbTypeCompound.SelectedValue}'");
            cbCompound.ValueMember = "idCompound";
            cbCompound.DisplayMember = "nameCompound";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DataBase.GetData("INSERT INTO [dbo].[Tests] ([idOrder],[idCompound],[numLoad]) " +
                $"VALUES ('{orderId}','{cbCompound.SelectedValue}','{nudLoadNumber.Value}')");

            this.Close();
        }
    }
}