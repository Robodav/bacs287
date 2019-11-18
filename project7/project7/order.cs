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
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();

            comboLower.SelectedIndex = 0;
            comboClub.SelectedIndex = 0;
            comboUpper.SelectedIndex = 0;

            string[] ticketsfile = System.IO.File.ReadAllLines("tickets.csv");
            string[] tickets = ticketsfile[1].Split(',');

            var lowerCount = int.Parse(tickets[0]);
            var clubCount = int.Parse(tickets[1]);
            var upperCount = int.Parse(tickets[2]);

            // If less than max tickets left, adjust combo box.
            if (lowerCount < 10)
            {
                // If no tickets left, display as sold out.
                adjustBox(lowerCount, comboLower, lblLower);
            }

            // Repeat the same process with club section tickets.
            if (clubCount < 10)
            {
                adjustBox(clubCount, comboClub, lblClub);
            }

            // Finally, repeat with upper level tickets.
            if (upperCount < 10)
            {
                adjustBox(upperCount, comboUpper, lblUpper);
            }
        }

        private void adjustBox(int count, ComboBox combo, Label label)
        // Adjusts combo boxes and respective labels to display appropriate number of tickets
        {
            if (count == 0)
            {
                combo.Visible = false;
                label.Text = "Sold Out";
            }
            else
            {
                for (int i = 0; i < (11 - count); i++)
                {
                    combo.Items.RemoveAt(count + 1);
                }
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            User.Lowticks = comboLower.SelectedItem.ToString();
            User.Clubticks = comboClub.SelectedItem.ToString();
            User.Upticks = comboUpper.SelectedItem.ToString();

            var lowerTotal = int.Parse(User.Lowticks) * 125;
            var clubTotal = int.Parse(User.Clubticks) * 75;
            var upperTotal = int.Parse(User.Upticks) * 50;
            var totalCost = lowerTotal + clubTotal + upperTotal;

            User.Cost = totalCost;

            this.Hide();
            frmPurchase purchase = new frmPurchase();
            purchase.ShowDialog();
        }
    }
}
