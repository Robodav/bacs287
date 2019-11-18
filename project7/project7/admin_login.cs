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
    public partial class frmAdminLogin : Form
    {
        public frmAdminLogin()
        {
            InitializeComponent();
        }

        private void LinkNewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmNewAdmin newadmin = new frmNewAdmin();
            newadmin.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FileFunctions filefuncs = new FileFunctions();
            string username = txtUsername.Text;
            if (filefuncs.checkUser(username, "admins.csv"))
            {
                string password = filefuncs.getField(username, 2, "admins.csv");
                if (password == txtPassword.Text)
                // Update user object and go to admin page if account exists and password matches.
                {
                    this.Hide();
                    User.Name = filefuncs.getField(username, 0, "admins.csv");
                    User.Email = username;
                    User.Password = password;
                    frmAdmin admin = new frmAdmin();
                    admin.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid password.");
                }
            }
            else
            {
                MessageBox.Show("An account does not exist with this username.");
            }
        }
    }
}
