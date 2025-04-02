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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ()
            {
                Admin A1 = new Admin();
                this.Visible = false;
                A1.ShowDialog();
            } else if ()
            {
                Order O1 = new Order();
                this.Visible = false;
                O1.ShowDialog();
            }
            else
            {

            }
        }
    }
}
