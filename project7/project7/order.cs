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

            // If less than 8 tickets left, adjust combo box.
            if (lowerCount < 8)
            {
                // If no tickets left, display as sold out.
                if (lowerCount == 0)
                {
                    comboLower.Visible = false;
                    lblLower.Text = "Sold Out";
                }
                // Make combo box show only the amount of tickets left at most.
                else
                {
                    for (int i = 0; i < (9 - lowerCount); i++)
                    {
                        comboLower.Items.RemoveAt(lowerCount + 1);
                    }
                }
            }

            // Repeat the same process with club section tickets.
            if (clubCount < 8)
            {
                if (clubCount == 0)
                {
                    comboClub.Visible = false;
                    lblClub.Text = "Sold Out";
                }
                else
                {
                    for (int i = 0; i < (9 - clubCount); i++)
                    {
                        comboClub.Items.RemoveAt(clubCount + 1);
                    }
                }
            }

            // Finally, repeat with upper level tickets.
            if (upperCount < 8)
            {
                if (upperCount == 0)
                {
                    comboUpper.Visible = false;
                    lblUpper.Text = "Sold Out";
                }
                else
                {
                    for (int i = 0; i < (9 - upperCount); i++)
                    {
                        comboUpper.Items.RemoveAt(upperCount + 1);
                    }
                }
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            var lowerTotal = int.Parse(comboLower.SelectedItem.ToString()) * 125;
            var clubTotal = int.Parse(comboLower.SelectedItem.ToString()) * 75;
            var upperTotal = int.Parse(comboLower.SelectedItem.ToString()) * 50;
            var totalCost = lowerTotal + clubTotal + upperTotal;
        }
    }
}
