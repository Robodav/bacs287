using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week6Coursework
{
    public partial class frmWeek6 : Form
    {
        int output = 0;
        public frmWeek6()
        {
            InitializeComponent();
        }

        private void BtnWhile_Click(object sender, EventArgs e)
        {
            int input = int.Parse(txtInput.Text);
            int count = 1;

            while (count <= input)
            {
                output += count;
                lstOutput.Items.Add(count + " " + output);
                count++;
            }
            txtResult.Text = output.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnDo_Click(object sender, EventArgs e)
        {
            int input = int.Parse(txtInput.Text);
            int count = 1;

            do
            {
                output += count;
                lstOutput.Items.Add(count + " " + output);
                count++;
            } while (count <= input);
            txtResult.Text = output.ToString();
        }

        private void BtnFor_Click(object sender, EventArgs e)
        {
            int input = int.Parse(txtInput.Text);

            for (int count=1; count<=input; count++)
            {
                output += count;
                lstOutput.Items.Add(count + " " + output);
            }
            txtResult.Text = output.ToString();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();
            txtInput.Clear();
            txtResult.Clear();
            txtInput.Focus();
        }
    }
}
