using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project4
{
    public partial class frmProject4 : Form
    {
        public frmProject4()
        {
            InitializeComponent();
        }

        private void BtnCalcTuition_Click(object sender, EventArgs e)
        {
            double tuition = 6000.00;
            double total = 0;
            int years = int.Parse(txtYears.Text);
            lstTuition.Items.Add("Year            Tuition");
            for (int i = 1; i <= years; i++)
            {
                string tuDisplay = i.ToString() + "                  " + tuition.ToString("c");
                lstTuition.Items.Add(tuDisplay);
                total += tuition;
                tuition += (tuition * .02);
            }
            txtTotalCost.Text = total.ToString("c");
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            int seriesEnd = int.Parse(txtInput.Text);
            int output = 1;
            if (radProduct.Checked && seriesEnd > 0)
            {
                int i = 1;
                while (i <= seriesEnd)
                {
                    output *= i;
                    i++;
                }
                txtOutput.Text = output.ToString();
            }
            else if (radSumOdd.Checked && seriesEnd > 0)
            {
                output = 0;
                double oddTotal = 0;
                for (int i = 1; i <= seriesEnd; i += 2)
                {
                    output += i;
                    oddTotal += output;
                }
                txtOutput.Text = oddTotal.ToString();
            }
        }
    }
}
