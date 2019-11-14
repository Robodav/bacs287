﻿using System;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        InputFunctions inputfuncs = new InputFunctions();
        FileFunctions filefuncs = new FileFunctions();

        private void LinkCreate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmNewAccount newAcc = new frmNewAccount();
            newAcc.ShowDialog();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            if (!inputfuncs.verifyEmail(email))
            {
                MessageBox.Show("Please enter a valid email address");
            }
            else if (filefuncs.checkUser(email))
            {
                string password = filefuncs.getPassword(email);
                if (password == txtPassword.Text)
                {
                    MessageBox.Show("Welcome back!");
                    User.Name = filefuncs.getName(email);
                    User.Email = email;
                    User.Password = password;
                }
                else
                {
                    MessageBox.Show("Invalid password.");
                }
            }
            else
            {
                MessageBox.Show("An account does not exist with that email address.");
            }
        }
    }
}
