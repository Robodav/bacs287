using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week9Coursework
{
    public partial class frmWeek9 : Form
    {
        public frmWeek9()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string[] info = new string[6]; //create array using textboxes
            info[0] = txtFirst.Text;
            info[1] = txtLast.Text;
            info[2] = txtAddress.Text;
            info[3] = txtCity.Text;
            info[4] = txtState.Text;
            info[5] = txtZip.Text;

            MessageBox.Show("Hello " + info[0]); //say hello with first name

            string display = ""; //string to display all info
            display += "Name: " + info[0] + " " + info[1] + "\n";
            display += "Street: " + info[2] + "\n";
            display += "City: " + info[3] + "\n";
            display += "State: " + info[4] + "\n";
            display += "Zip Code: " + info[5] + "\n";
            MessageBox.Show(display);

            string CustomerRecord = string.Join(",", info); //turn array into comma separated string
            MessageBox.Show("The Joined Array: " + CustomerRecord);

            System.IO.File.AppendAllText("customers.txt", CustomerRecord + "\r \n"); //write comma separated string to file
        }
    }
}
