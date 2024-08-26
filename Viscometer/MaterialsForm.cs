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
    public partial class MaterialsForm : Form
    {
        public MaterialsForm()
        {
            InitializeComponent();
        }

        private void MaterialsForm_Load(object sender, EventArgs e)
        {
            cbTypeOfCompound.DataSource = DataBase.GetData("SELECT * FROM [Viscosimeters].[dbo].[TypeOfCompound]");
            cbTypeOfCompound.DisplayMember = "nameTypeCompound";
            cbTypeOfCompound.ValueMember = "idTypeCompound";
            cbTypeOfCompound.SelectedIndexChanged += CbTypeOfCompound_SelectedIndexChanged;
            UpdeteCompounds();
        }

        private void UpdeteCompounds()
        {
            listBoxMain.DataSource = DataBase.GetData("SELECT Compounds.nameCompound, Compounds.idCompound " +
                "FROM Compounds " +
                $"WHERE idType = '{cbTypeOfCompound.SelectedValue}'");
            listBoxMain.DisplayMember = "nameCompound";
            listBoxMain.ValueMember = "idCompound";
        }

        private void CbTypeOfCompound_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdeteCompounds();
        }

        private void Add()
        {
            if (txtForAdd.Text.Trim() == String.Empty) return;
            DataBase.GetData("INSERT INTO [dbo].[Compounds] " +
                "([nameCompound] ,[idType]) " +
                "VALUES " +
                $"('{txtForAdd.Text.Trim()}', '{cbTypeOfCompound.SelectedValue}')");
            txtForAdd.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
            UpdeteCompounds();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите удалить?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataBase.GetData("DELETE FROM [dbo].[Compounds] " +
                $"WHERE idCompound = '{listBoxMain.SelectedValue}'");
                UpdeteCompounds();
            }
        }

        private void txtForAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Add();
                UpdeteCompounds();
            }
        }
    }
}
