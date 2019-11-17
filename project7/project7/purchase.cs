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
    public partial class frmPurchase : Form
    {
        public frmPurchase()
        {
            InitializeComponent();

            lblCost.Text = User.Cost.ToString("c");
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                decimal.Parse(txtCreditCard.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid credit card number.");
            }

            try
            {
                int.Parse(txtCSV.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid CSV.");
            }

            if (txtCreditCard.Text.Length == 16)
            {
                if (txtCSV.Text.Length == 3)
                {
                    User.CSV = txtCSV.Text;
                }
                else
                {
                    MessageBox.Show("CSV must be 3 digits long.");
                    return;
                }
                User.CreditCard = txtCreditCard.Text;
                User.CCName = txtName.Text;

                string confirmationMessage = generateConfirmationMessage();
                MessageBox.Show(confirmationMessage);
            }
            else
            {
                MessageBox.Show("Credit card number must be 16 digits long.");
                return;
            }
        }

        private string generateConfirmationMessage()
        {
            string message;
            message = "Can't wait to see you, " + User.Name + "!";
            message += "Summary:";
            message += "Amount to be charged: " + User.Cost;
            message += "Contact email: " + User.Email;
            message += "\nPlease click YES below to confirm your order.";
            return message;
        }
    }
}
