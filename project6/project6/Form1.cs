using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace project6
{
    public partial class frmProject6 : Form
    {
        public frmProject6()
        {
            InitializeComponent();
        }

        string[] teams = File.ReadAllLines("teams.txt");
        string[] yearsWinners = File.ReadAllLines("YearsWinners.txt");
    }
}
