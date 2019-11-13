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
    public partial class frmNewAccount : Form
    {
        public frmNewAccount()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            InputFunctions inputfuncs = new InputFunctions();
            FileFunctions filefuncs = new FileFunctions();
            if (!inputfuncs.verifyEmail(txtEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address.");
            }
            else if (filefuncs.checkUser(txtEmail.Text))
            {
                MessageBox.Show("An account already exists with this email address.");
            }
            else if (txtConfirm.Text != txtPassword.Text)
            {
                MessageBox.Show("Passwords must match!");
            }
            else
            {
                filefuncs.writeUser(txtName.Text, txtAge.Text, txtEmail.Text, txtPassword.Text, "0");
                this.Hide();
                frmLogin login = new frmLogin();
                login.ShowDialog();
            }
            
        }

        private void btnTogglePassView_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
