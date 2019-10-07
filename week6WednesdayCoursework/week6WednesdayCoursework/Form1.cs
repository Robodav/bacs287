using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week6WednesdayCoursework
{
    public partial class frmWed : Form
    {
        public frmWed()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(txtTemp.Text); //convert temperature
            txtOutput.Text = OutfitCalculate(temp);
            CoatDisplay(temp);
        }

        private string OutfitCalculate(int temp) //calculates which outfit to display
        {
            if (temp < 30)
            {
                return "Heavy Coat";
            }

            else if (temp < 50)
            {
                return "Sweat Shirt";
            }

            else
            {
                return "No Coat";
            }
        }

        private void CoatDisplay(int temp) //decides whether or not to display coat image
        {
            if (temp < 40)
            {
                imgCoat.Visible = true;
            }
            else
            {
                imgCoat.Visible = false;
            }
        }
    }
}
