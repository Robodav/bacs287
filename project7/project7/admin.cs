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
        // Search the data table for the confirmation number and highlight the associated row if found.
        {
            dataCustomers.ClearSelection();
            for (int i=0; i<dataCustomers.Rows.Count-1; i++)
            {
                if (dataCustomers.Rows[i].Cells[3].Value.ToString() == txtConfirmation.Text)
                {
                    dataCustomers.Rows[i].Selected = true;
                    MessageBox.Show(generateConfirmationMessage(), "Confirmation found");
                    return;
                }
            }
            MessageBox.Show("No results found.");
        }

        private void generateDataTable()
        // Populate the datagridview control with data from users.csv.
        {
            // Create column headers.
            dataCustomers.ColumnCount = 7;
            dataCustomers.Columns[0].Name = "Customer";
            dataCustomers.Columns[1].Name = "Email";
            dataCustomers.Columns[2].Name = "Total Cost";
            dataCustomers.Columns[3].Name = "Confirmation Number";
            dataCustomers.Columns[4].Name = "Lower Level Seats";
            dataCustomers.Columns[5].Name = "Club Level Seats";
            dataCustomers.Columns[6].Name = "Upper Deck Seats";

            // Use file functions getCustomerData to populate rows with information.
            FileFunctions filefuncs = new FileFunctions();
            string[][] data = filefuncs.getCustomerData();
            for (int i=1; i<data.Length; i++)
            {
                dataCustomers.Rows.Add(data[i]);
            }
        }

        private string generateConfirmationMessage()
        {
            string name = dataCustomers.SelectedRows[0].Cells[0].Value.ToString();
            string charge = dataCustomers.SelectedRows[0].Cells[2].Value.ToString();
            string message = "Found confirmation number: " + txtConfirmation.Text + "\n";
            message += "Name: " + name + "\n";
            message += "Total charge: $" + charge;
            return message;
        }
    }
}
