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
    public partial class frmProfile : Form
    {
        public frmProfile()
        {
            InitializeComponent();
            lblName.Text = User.Name;
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {

        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {

        }
    }
}
