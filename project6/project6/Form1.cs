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

        private void BtnClear_Click(object sender, EventArgs e) // clears all text boxes
        {
            lstTeams.Items.Clear();
            txtChampionships.Text = "";
            txtThisYear.Text = "";
            changeTopText();
        }

        private void ComboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstTeams.Items.Clear();
            if (comboFilter.Text == "Ascending") // displays teams to list box in ascending order alphabetically
            {
                var teamAscending = from team in teams
                                    orderby team ascending
                                    select team;

                foreach (string team in teamAscending)
                {
                    lstTeams.Items.Add(team);
                }
            }
            else if (comboFilter.Text == "Descending") // displays teams to list box in descending order alphabetically
            {
                var teamDescending = from team in teams
                                     orderby team descending
                                     select team;

                foreach (string team in teamDescending)
                {
                    lstTeams.Items.Add(team);
                }
            }
            else if (comboFilter.Text == "Winners with Years") // displays to the list box every year from 1903 to 2019 alongside the team that won that year
            {
                lstTeams.Items.Clear();
                var teamWithYear = from year in yearsWinners
                                   orderby year descending
                                   let winyear = year.Split('|')
                                   let time = winyear[0]
                                   let team = winyear[1]
                                   select new { time, team };

                foreach (var team in teamWithYear)
                {
                    lstTeams.Items.Add("In " + team.time + " the winner was: " + team.team);
                }
            }
            else if (comboFilter.Text == "Deduplicated") // displays to the list box each unique team to the list box
            {
                List<String> deduplicated = deduplicate();

                foreach (string team in deduplicated)
                {
                    lstTeams.Items.Add(team);
                }
            }
            else // displays to the list box all teams that have won exactly 1 championship
            {
                List<String> winners = deduplicate();

                foreach (string team in winners)
                {
                    int wins = getNumWins(team);

                    if (wins == 1)
                    {
                        lstTeams.Items.Add(team);
                    }
                }

            }
            changeTopText();
        }

        private void BtnCalculate_Click(object sender, EventArgs e) // updates list box to display any teams that won the amount of times entered under 'who has won this many championships?'
        {
            try
            {
                int.Parse(txtChampionships.Text);
            }
            catch
            {
                MessageBox.Show("Input must be numeric!");
                return;
            }

            int numChampionships = int.Parse(txtChampionships.Text);

            if (numChampionships > 0)
            {
                lstTeams.Items.Clear();
                List<string> winners = deduplicate();
                foreach (string team in winners)
                {
                    if (getNumWins(team) == numChampionships)
                    {
                        lstTeams.Items.Add(team);
                    }
                }
            }
            else
            {
                MessageBox.Show("Input must be greater than 0!");
                return;
            }
            
            changeTopText();
        }

        private void BtnSubmit_Click(object sender, EventArgs e) // updates list box to display team that won in the year entered under 'who won this year?'
        {
            lstTeams.Items.Clear();
            try
            {
                int.Parse(txtThisYear.Text);
            }
            catch
            {
                MessageBox.Show("Input must be numeric!");
                return;
            }

            int thisYear = int.Parse(txtThisYear.Text);

            if (thisYear >= 1903 && thisYear <= 2019)
            {
                var teamWithYear = from year in yearsWinners
                                   orderby year descending
                                   let winyear = year.Split('|')
                                   let time = winyear[0]
                                   let team = winyear[1]
                                   select new { time, team };

                foreach (var team in teamWithYear)
                {
                    if (team.time == txtThisYear.Text)
                    {
                        lstTeams.Items.Add(team.team);
                    }
                }
            }
            else
            {
                MessageBox.Show("Year must be between 1903 and 2019!");
                return;
            }
            changeTopText();
        }

        private List<String> deduplicate() // returns a list containing the names of each unique team
        {
            List<String> uniqueTeams = new List<string>();
            var deduplicated = (from team in teams
                                select team).Distinct();

            foreach (string team in deduplicated)
            {
                uniqueTeams.Add(team);
            }

            return uniqueTeams;
        }

        private int getNumWins(string team) // returns the number of wins of the inputted team
        {
            var winsQuery = from winner in teams
                            where winner == team
                            select winner;

            return winsQuery.Count();
        }

        private void changeTopText() // updates text over list box to display number of items contained
        {
            lblTeams.Text = lstTeams.Items.Count.ToString() + " Total teams.";
        }
    }
}
