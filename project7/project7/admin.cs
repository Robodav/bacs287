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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
            // Adjust label values on form.
            FileFunctions filefuncs = new FileFunctions();
            lblSalesNum.Text = filefuncs.getTotalSales().ToString();
            lblLowerNum.Text = filefuncs.getTicks(0);
            lblClubNum.Text = filefuncs.getTicks(1);
            lblUpperNum.Text = filefuncs.getTicks(2);
            generateDataTable();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }

        private void generateDataTable()
        {
            dataCustomers.ColumnCount = 7;
            dataCustomers.Columns[0].Name = "Customer";
            dataCustomers.Columns[1].Name = "Email";
            dataCustomers.Columns[2].Name = "Total Cost";
            dataCustomers.Columns[3].Name = "Confirmation Number";
            dataCustomers.Columns[4].Name = "Lower Level Seats";
            dataCustomers.Columns[5].Name = "Club Level Seats";
            dataCustomers.Columns[6].Name = "Upper Deck Seats";

            FileFunctions filefuncs = new FileFunctions();
            string[][] data = filefuncs.getCustomerData();
            for (int i=1; i<data.Length; i++)
            {
                dataCustomers.Rows.Add(data[i]);
            }
        }
    }
}
