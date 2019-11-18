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
                confirmationForm();
                this.Hide();
                frmProfile profile = new frmProfile();
                profile.ShowDialog();
            }
            else
            {
                MessageBox.Show("Credit card number must be 16 digits long.");
                return;
            }
        }

        private void confirmationForm()
        // Confirmation message displays if all information passes error checking.
        {
            string confirmationMessage = generateConfirmationMessage();
            var confirm = MessageBox.Show(confirmationMessage, "Purchase Confirmation",
                                          MessageBoxButtons.YesNoCancel);
            if (confirm == DialogResult.Yes)
            {
                FileFunctions filefuncs = new FileFunctions();

                // Update database after purchase is confirmed.
                filefuncs.writeField(User.Email, 5, User.CreditCard);
                filefuncs.writeField(User.Email, 6, User.CCName);
                filefuncs.writeField(User.Email, 7, User.CSV);
                filefuncs.writeField(User.Email, 8, User.Lowticks);
                filefuncs.writeField(User.Email, 9, User.Clubticks);
                filefuncs.writeField(User.Email, 10, User.Upticks);
                filefuncs.writeField(User.Email, 12, User.Cost.ToString());

                filefuncs.adjustTicks("lower", "subtract", int.Parse(User.Lowticks));
                filefuncs.adjustTicks("club", "subtract", int.Parse(User.Clubticks));
                filefuncs.adjustTicks("upper", "subtract", int.Parse(User.Upticks));

                User.Confirmation = filefuncs.generateConfirmationNumber().ToString();
                filefuncs.writeField(User.Email, 11, User.Confirmation);

                MessageBox.Show(generateCongratsMessage());
            }
        }

        private string generateConfirmationMessage()
        // Custom confirmation message generated based on user info.
        {
            string message;
            message = "Can't wait to see you, " + User.Name + "!\n";
            message += "Summary:\n";
            message += "Amount to be charged: $" + User.Cost + "\n";
            message += "Contact email: " + User.Email + "\n";
            message += "\nPlease click YES below to confirm your order.";
            return message;
        }

        private string generateCongratsMessage()
        // Custom information for final messagebox showing confirmation number.
        {
            string message;
            message = "Congrats!\n";
            message += "Your confirmation number: " + User.Confirmation;
            return message;
        }
    }
}
