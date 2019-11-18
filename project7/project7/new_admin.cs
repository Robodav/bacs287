using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project7
{
    public partial class frmNewAdmin : Form
    {
        public frmNewAdmin()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            FileFunctions filefuncs = new FileFunctions();
            if (filefuncs.checkUser(txtUsername.Text, "admins.csv"))
            {
                MessageBox.Show("An account already exists with this username.");
            }
            else if (txtPassword.Text != txtConfirm.Text)
            {
                MessageBox.Show("Passwords must match.");
            }
            else
            {
                filefuncs.writeUser("admins.csv");
                this.Hide();
                frmAdminLogin adminlogin = new frmAdminLogin();
                adminlogin.ShowDialog();
            }
        }

        private void btnToggleVisibility_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtConfirm.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtConfirm.UseSystemPasswordChar = true;
            }
        }
    }
}
