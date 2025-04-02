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
    public partial class cmbLoginID : Form
    {
        public cmbLoginID()
        {
            InitializeComponent();
        }

        //global variables
        int invalidAdminCount = 0;
        int invalidCustomerCount = 0;
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String strLogin = cmbLogin.SelectedItem.ToString();
            String strPassword = txtPassword.Text;

            if (strLogin == "Admin" && strPassword == "123")
            {
                //go to admin page
                Admin A1 = new Admin();
                this.Visible = false;
                A1.ShowDialog();
            } else if (strLogin == "Customer" && strPassword == "456")
            {
                //go to order page
                Order O1 = new Order();
                this.Visible = false;
                O1.ShowDialog();
            }
            else
            {
                //when login and password are incorrect
                MessageBox.Show("Invalid login ID or password", "ERROR");

                //when login is admin but password is wrong
                if (strLogin == "Admin" && strPassword != "123") 
                { 
                    //count invalid admin attempts
                    invalidAdminCount++;
                    if (invalidAdminCount >= 3)
                    {
                        MessageBox.Show("Too many failed attempts. Application will close.", "Login failed");
                        Application.Exit();
                    }
                }

                //when login is customer but password is wrong
                if (strLogin == "Customer" && strPassword != "456")
                {
                    //count invalid customer attempts
                    invalidCustomerCount++;
                    if (invalidCustomerCount >= 3)
                    {
                        MessageBox.Show("Too many failed attempts. Application will close.", "Login failed");
                        Application.Exit();
                    }
                }
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmbLogin.SelectedIndex = -1;
            txtPassword.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
