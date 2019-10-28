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

namespace week8Coursework
{
    public partial class frmWeek8 : Form
    {
        public frmWeek8()
        {
            InitializeComponent();
            loadArray();
        }

        string[] winners;
        string[] winnerdates;

        public void loadArray() // reads all winners in file and adds them to global winners array
        {
            winners = File.ReadAllLines("winners.txt");
            winnerdates = File.ReadAllLines("winnersdates.txt");
        }

        private void BtnDisplay_Click(object sender, EventArgs e) // displays winners in default order to listbox
        {
            lstDisplay.Items.Clear();
            foreach (string winner in winners)
            {
                lstDisplay.Items.Add(winner);
            }
        }

        private void BtnAscending_Click(object sender, EventArgs e) // displays winners in ascending alphabetic order to listbox
        {
            lstDisplay.Items.Clear();
            var ascendingQuery = from winner in winners
                               orderby winner ascending
                               select winner;

            foreach (string winner in ascendingQuery)
            {
                lstDisplay.Items.Add(winner);
            }

        }

        private void BtnByDate_Click(object sender, EventArgs e) // displays winners in ascending date order to listbox
        {
            lstDisplay.Items.Clear();
            var teambyyear = from year in winnerdates
                             let winyear = year.Split(',')
                             let time = winyear[0]
                             let name = winyear[1]
                             select new { time, name };

            foreach(var team in teambyyear)
            {
                lstDisplay.Items.Add(team.time + " the winner was: " + team.name);
            }
    
        }

        private void BtnCalculate_Click(object sender, EventArgs e) // counts how many times the inputted team won and displays it to the next box
        {
            string teamName = txtTeam.Text.ToLower();

            var winsQuery = from winner in winners
                            where winner.ToLower() == teamName
                            select winner;

            txtWins.Text = winsQuery.Count().ToString();
        }
    }
}
