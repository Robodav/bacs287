using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project3
{
    public partial class frmProject3 : Form
    {
        double total = 0.00;
        int calories = 0;
        int fat = 0;
        int protein = 0;
        int sodium = 0;
        public frmProject3()
        {
            InitializeComponent();
        }

        private void ListItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PicSandwich_Click(object sender, EventArgs e)
        {
            total += 3.15;
            calories += 440;
            fat += 19;
            protein += 28;
            sodium += 1350;
            listItems.Items.Add("Chicken Sandwich $3.15");
            txtCalories.Text = calories.ToString();
            txtFat.Text = fat.ToString() + "g";
            txtProtein.Text = protein.ToString() + "g";
            txtSodium.Text = sodium.ToString() + "mg";
            txtTotal.Text = total.ToString("c");
        }

        private void PicNuggets_Click(object sender, EventArgs e)
        {
            total += 4.75;
            calories += 260;
            fat += 12;
            protein += 28;
            sodium += 980;
            listItems.Items.Add("Chicken Nuggets $4.75");
            txtCalories.Text = calories.ToString();
            txtFat.Text = fat.ToString() + "g";
            txtProtein.Text = protein.ToString() + "g";
            txtSodium.Text = sodium.ToString() + "mg";
            txtTotal.Text = total.ToString("c");
        }

        private void PicCola_Click(object sender, EventArgs e)
        {
            total += 2.75;
            calories += 260;
            fat += 0;
            protein += 0;
            sodium += 90;
            listItems.Items.Add("Large Coca Cola $2.75");
            txtCalories.Text = calories.ToString();
            txtFat.Text = fat.ToString() + "g";
            txtProtein.Text = protein.ToString() + "g";
            txtSodium.Text = sodium.ToString() + "mg";
            txtTotal.Text = total.ToString("c");
        }

        private void PicFries_Click(object sender, EventArgs e)
        {
            total += 1.85;
            calories += 365;
            fat += 18;
            protein += 5;
            sodium += 280;
            listItems.Items.Add("Waffle Fries $1.85");
            txtCalories.Text = calories.ToString();
            txtFat.Text = fat.ToString() + "g";
            txtProtein.Text = protein.ToString() + "g";
            txtSodium.Text = sodium.ToString() + "mg";
            txtTotal.Text = total.ToString("c");
        }

        private void PicSalad_Click(object sender, EventArgs e)
        {
            total += 7.19;
            calories += 330;
            fat += 14;
            protein += 27;
            sodium += 670;
            listItems.Items.Add("Chicken Salad $7.19");
            txtCalories.Text = calories.ToString();
            txtFat.Text = fat.ToString() + "g";
            txtProtein.Text = protein.ToString() + "g";
            txtSodium.Text = sodium.ToString() + "mg";
            txtTotal.Text = total.ToString("c");
        }

        private void PicDrPepper_Click(object sender, EventArgs e)
        {
            total += 2.75;
            calories += 260;
            fat += 0;
            protein += 0;
            sodium += 90;
            listItems.Items.Add("Large Dr. Pepper $2.75");
            txtCalories.Text = calories.ToString();
            txtFat.Text = fat.ToString() + "g";
            txtProtein.Text = protein.ToString() + "g";
            txtSodium.Text = sodium.ToString() + "mg";
            txtTotal.Text = total.ToString("c");
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            total = 0.00;
            calories = 0;
            fat = 0;
            protein = 0;
            sodium = 0;
            txtTotal.Text = "0.00";
            txtCalories.Text = "0";
            txtSodium.Text = "0";
            txtFat.Text = "0";
            txtProtein.Text = "0";
            listItems.Items.Clear();
        }
    }
}
