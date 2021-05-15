using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringMan2._0_p
{

    public partial class frmMainMenu : Form
    {
        public string Output_Transfer;

        public frmMainMenu()
        {
            InitializeComponent();
            Output_Transfer = string.Empty;
        }

        private void lblCloseMainMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlShowStringManV1_Paint(object sender, PaintEventArgs e)
        {
            frmStringManV1 StringManV1 = new frmStringManV1();
            this.Hide();
            StringManV1.ShowDialog();
        }
    }
}
