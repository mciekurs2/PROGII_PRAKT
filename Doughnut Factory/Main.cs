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

        private DougnutMachine myDoughnutMachine;

        private int mRaisedGlazed;
        private int mRaisedSugar;
        private int mRaisedChocolate;

        private int mCakePlain;
        private int mCakeChocolate;
        private int mCakeSugar;

        private int mFilledLemon;
        private int mFilledGrapge;
        private int mFilledCustard;



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

        private void frmMain_Load(object sender, EventArgs e)
        {
            myDoughnutMachine = new DougnutMachine();
            myDoughnutMachine.DoughnuntComplite += new DougnutMachine.DoughnutCompliteDelegate(DoughnutCompliteHandeler);
            


        }

        private void mnuRaisedGlazed_Clicked(object sender, EventArgs e)
        {
            menuRaisedGlazzed.Checked = true;
            menuRaisedChocolade.Checked = false;
            menuRaisedSugar.Checked = false;

            myDoughnutMachine.MakeDoughnuts(DougnutMachine.DougnutType.Glazed);
        }

        private void menuRaisedSugar_Click(object sender, EventArgs e)
        {
            menuRaisedGlazzed.Checked = true;
            menuRaisedChocolade.Checked = true;
            menuRaisedSugar.Checked = false;

            myDoughnutMachine.MakeDoughnuts(DougnutMachine.DougnutType.Sugar);


        }

        private void menuRaisedChocolade_Click(object sender, EventArgs e)
        {
            menuRaisedGlazzed.Checked = false;
            menuRaisedChocolade.Checked = false;
            menuRaisedSugar.Checked = true;

            myDoughnutMachine.MakeDoughnuts(DougnutMachine.DougnutType.Chocolate);
        }

        private void DoughnutCompliteHandeler()
        {
            switch (myDoughnutMachine.Flavor)
            {
                case DougnutMachine.DougnutType.Glazed:
                    mRaisedGlazed++;
                    txtGlazzedRaised.Text = mRaisedGlazed.ToString();
                    break;
                case DougnutMachine.DougnutType.Sugar:
                    mRaisedSugar++;
                    txtSugarRaised.Text = mRaisedSugar.ToString();
                    break;
                case DougnutMachine.DougnutType.Chocolate:
                    mRaisedChocolate++;
                    txtChocolateRaised.Text = mRaisedChocolate.ToString();
                    break;
            }
        }

        private void menuStop_Click(object sender, EventArgs e)
        {
            myDoughnutMachine.Enable = true;
        }
    }
}
