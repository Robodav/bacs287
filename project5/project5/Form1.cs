using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project5
{
    public partial class frmProject5 : Form
    {
        public frmProject5()
        {
            InitializeComponent();
        }

        double weight;
        double distance;

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtWeight.Text = "";
            txtDistance.Text = "";
            radUPS.Checked = false;
            radFedex.Checked = false;
            radUSPS.Checked = false;
            lblUpcharge.Text = "";
            lblCostDisplay.Text = "$0.00";
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double.Parse(txtWeight.Text);
                double.Parse(txtDistance.Text);
            }
            catch
            {
                MessageBox.Show("Error - input must be a numeric value");
            }
            weight = double.Parse(txtWeight.Text);
            distance = double.Parse(txtDistance.Text);
            if (weight < 0 || distance < 0)
            {
                MessageBox.Show("Error - input must be greater than 0");
            }

            if (radUPS.Checked)
            {
                lblCostDisplay.Text = calculateUPS().ToString("c");
            }
            else if (radFedex.Checked)
            {
                lblCostDisplay.Text = calculateFedex().ToString("c");
            }
            else if (radUSPS.Checked)
            {
                if (calculateUSPS() == 0)
                {
                    MessageBox.Show("Error - USPS will not ship more than 25 lbs");
                }
                else
                {
                    lblCostDisplay.Text = calculateUSPS().ToString("c");
                }
            }
            else
            {
                MessageBox.Show("Error - you have to select a carrier");
            }
        }

        private double calculateUPS()
        {
            double price;
            if (distance > 500)
            {
                price = 4.5 * weight;
            }
            else if (distance > 100)
            {
                price = 5.75 * weight;
            }
            else
            {
                price = 6.4 * weight;
            }
            return price;
        }

        private double calculateFedex()
        {
            double price;
            if (distance > 1000)
            {
                price = 14.5 * weight;
            }
            else if (distance > 500)
            {
                price = 9.75 * weight;
            }
            else
            {
                price = 4.75 * weight;
            }
            return price;
        }

        private double calculateUSPS()
        {
            double price;
            bool upcharge = (distance > 500); //account upcharge of 1.25 per pound over 500 miles
            if (weight > 25) //usps won't ship over 25 pounds
            {
                price = 0;
            }
            else if (weight > 10)
            {
                if (upcharge)
                {
                    price = 2.75 * weight;
                }
                else
                {
                    price = 1.5 * weight;
                }
            }
            else if (weight > 1)
            {
                if (upcharge)
                {
                    price = 3 * weight;
                }
                else
                {
                    price = 1.75 * weight;
                }
            }
            else
            {
                if (upcharge)
                {
                    price = 5.15 * weight;
                }
                else
                {
                    price = 3.9 * weight;
                }
            }
            if (upcharge)
            {
                double upchargeAmount = 1.25 * weight;
                lblUpcharge.Text = "Note: Mileage upcharge of " + upchargeAmount.ToString("c");
            }
            return price;
        }
    }
}
