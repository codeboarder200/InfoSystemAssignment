using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoSystemAssignment
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        public static string InputBox(string prompt, string title, string defaultValue)
        {
            InputBoxDialog ib = new InputBoxDialog();
            ib.FormPrompt = prompt;
            ib.FormCaption = title;
            ib.DefaultValue = defaultValue;
            ib.ShowDialog();
            string s = ib.InputResponse;
            ib.Close();
            return s;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            cmbLoginID l1 = new cmbLoginID();
            this.Visible = false;
            l1.ShowDialog();
        }
        //global variables
        int intArrayCount;
        private void btnAddCaterType_Click(object sender, EventArgs e)
        {
            String getCaterType;
            double getCaterCost; 
            string[] CateringTypeArray = new string[3];
            double[] CateringCostArray = new double[3];

            for (intArrayCount = 0; intArrayCount < CateringTypeArray.Length; intArrayCount++)
            {
                //get catering type and cost from admin
                getCaterType = InputBox("Please enter a catering type", "Catering type input", "");
                getCaterCost = Convert.ToDouble(InputBox("Please enter the catering cost", "Catering cost input", ""));

                //put catering type and cost into array
                CateringTypeArray[intArrayCount] += getCaterType;
                CateringCostArray[intArrayCount] += getCaterCost;
            }

            //store catering type and cost arrays into array class
            CateringArrayClass.CateringType = CateringTypeArray;
            CateringArrayClass.CateringCost = CateringCostArray;
        }
    }
}
