using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoSystemAssignment
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        //declare constants
        const double dblDelivery = 450;
        const double dblWaiters = 200;
        const double dblFullBar = 350;
        const double dblWineAndOthers = 200;
        const double dblSoftDrinks = 100;
        const double dblVAT = 0.15;

        //global variables
        double dblCateringCost = 0;
        int intArrayCount;

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime bookingDate = dtpDate.Value; //get date value
            lblOutput.Text = "Catering booked for " + bookingDate.ToString("dddd dd MMMM"); //display date value

            //local variables
            double dblTotCost = 0;
            double dblVATAmount = 0;
            String strTotCost;
            double dblFinalCost = 0;
            int intNoPeople = (int)nudNoPeople.Value;
            bool blnValidInput = true;

            blnValidInput = ValidateOrderInput(blnValidInput);

            if (blnValidInput == true)
            {
                dblTotCost = CalcCateringCost(intNoPeople, dblTotCost);

                //add 15% VAT
                dblVATAmount = dblTotCost * dblVAT;
                dblFinalCost = dblTotCost + dblVATAmount;

                //display total cost
                strTotCost = dblTotCost.ToString("C2");
                lblCostOfCatering.Text = strTotCost;
            }
        }

        public bool ValidateOrderInput(bool validInput)
        {
            if (cmbCaterType.SelectedIndex == -1) 
            {
                validInput = false;
                MessageBox.Show("Please select a catering type", "ERROR");
            }

            if (dtpDate.Value < DateTime.Today.AddDays(7))
            {
                validInput = false;
                MessageBox.Show("Invalid date of choose", "ERROR");
            }

            if (nudNoPeople.Value == 0)
            {
                validInput = false;
                MessageBox.Show("Please enter the number of people", "ERROR");
            }

            return validInput;
        }

        private double CalcCateringCost(int intNoPeople, double dblTotCost)
        {
            dblCateringCost = CateringArrayClass.CateringCost[cmbCaterType.SelectedIndex] * intNoPeople;   //correct


            if (chkDelivery.Checked == true)
            {
                dblTotCost += dblDelivery;
            }

            if (chkWaiters.Checked == true)
            {
                dblTotCost += (dblWaiters * intNoPeople);
            }

            if (radFullBar.Checked == true)
            {
                dblTotCost += (dblFullBar * intNoPeople);
            }
            else if (radWineAndOthers.Checked == true)
            {
                dblTotCost += (dblWineAndOthers * intNoPeople);
            }
            else
            {
                if (radSoftDrinks.Checked == true)
                {
                    dblTotCost += (dblSoftDrinks * intNoPeople);
                }
            }

            dblTotCost += dblCateringCost;

            return dblTotCost;
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmbCaterType.SelectedIndex = -1;
            nudNoPeople.Value = 0;
            nudNoPeople.Select();
            dtpDate.Value = DateTime.Today;
            lblCostOfCatering.Text = "R0.00";
            lblOutput.Text = "X";
            radFullBar.Checked = false;
            radSoftDrinks.Checked = false;
            radWineAndOthers.Checked = false;
            chkDelivery.Checked= false;
            chkWaiters.Checked = false;
            cmbCaterType.Focus();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmbLoginID l1 = new cmbLoginID();
            this.Visible = false;
            l1.ShowDialog();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the Order Page!");
            //add catering types to combo box on Order page
            for (intArrayCount = 0; intArrayCount < CateringArrayClass.CateringType.Length; intArrayCount++)
            {
                cmbCaterType.Items.Add(CateringArrayClass.CateringType[intArrayCount]);
            }

            this.ActiveControl = cmbCaterType;
        }
    }
}
