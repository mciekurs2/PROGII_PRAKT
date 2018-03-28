using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Doughnut_Factory
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false)
                errorProvider1.SetError(txtQuantity, "Lūdzu ievadi tikai ciparus");
            else
                errorProvider1.SetError(txtQuantity, "");
        }

        private void txtQuantity_Validating(object sender, CancelEventArgs e)
        {
            if (txtQuantity.Text == "")
            {
                errorProvider1.SetError(txtQuantity, "Lūdzu ievadi daudzumu!");
                e.Cancel = true;
            }
            else if (errorProvider1.GetError(txtQuantity) != "")
            {
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtQuantity, "");
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
