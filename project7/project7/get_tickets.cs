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
    public partial class frmGetTickets : Form
    {
        public frmGetTickets()
        {
            InitializeComponent();
        }

        private void LinkAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            User.Role = "1";
            frmAdminLogin adminlogin = new frmAdminLogin();
            adminlogin.ShowDialog();
            this.Close();
        }

        private void BtnGetTickets_Click(object sender, EventArgs e)
        {
            this.Hide();
            User.Role = "0";
            frmLogin login = new frmLogin();
            login.ShowDialog();
            this.Close();
        }
    }
}
