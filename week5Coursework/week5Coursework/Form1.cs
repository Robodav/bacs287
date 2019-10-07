using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week5Coursework
{
    public partial class frmWeek5 : Form
    {
        public frmWeek5()
        {
            InitializeComponent();
            int totalCalories = int.Parse(txtCalories.Text);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtCalories.Text = "0";
        }

        private void PicApples_Click(object sender, EventArgs e)
        {
            int calories = 95;
            int totalCals = int.Parse(txtCalories.Text);
            int newTotal = totalCals + calories;
            txtCalories.Text = newTotal.ToString();
        }

        private void PicPeas_Click(object sender, EventArgs e)
        {
            int calories = 118;
            int totalCals = int.Parse(txtCalories.Text);
            int newTotal = totalCals + calories;
            txtCalories.Text = newTotal.ToString();
        }

        private void PicPeach_Click(object sender, EventArgs e)
        {
            int calories = 58;
            int totalCals = int.Parse(txtCalories.Text);
            int newTotal = totalCals + calories;
            txtCalories.Text = newTotal.ToString();
        }

        private void PicCarrots_Click(object sender, EventArgs e)
        {
            int calories = 25;
            int totalCals = int.Parse(txtCalories.Text);
            int newTotal = totalCals + calories;
            txtCalories.Text = newTotal.ToString();
        }
    }
}
