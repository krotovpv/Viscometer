using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViscometerViewer
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
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddOrderForm().ShowDialog();
        }

    }
}
