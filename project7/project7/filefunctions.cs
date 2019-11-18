using System;
using System.Collections.Generic;

namespace project7
{
    public class FileFunctions
    {
        public FileFunctions()
        {

        }

        public void writeUser(string path) 
        // Writes a new user to the specified path.
        {
            string userInfo;
            if (path == "admins.csv")
            {
                userInfo = "\n" + User.Name + "," + User.Username + "," + User.Password;
            }
            else
            {
                userInfo = "\n" + User.Name + "," + User.Email + "," + User.Age + "," + User.Password;
                userInfo += ",0,0,0,0,0,0,0,0";
            }
            System.IO.File.AppendAllText(path, userInfo);
        }

        public bool checkUser(string identifier, string path) 
        // Checks if a user exists in the specified path using the given identifier.
        {
            string[] users = System.IO.File.ReadAllLines(path);
            foreach (string user in users)
            {
                string[] individual = user.Split(',');
                if (individual[1] == identifier)
                {
                    return true;
                }
            }
            return false;
        }

        public string getField(string id, int field, string path) 
        // Returns value of index field for user based on specified identifier from file.
        {
            string[] rows = System.IO.File.ReadAllLines(path);
            foreach (string row in rows)
            {
                string[] individual = row.Split(',');
                if (individual[1] == id)
                {
                    return individual[field];
                }
            }
            return "User not found!";
        }

        public void writeField(string id, int field, string data, string path)
        // Overwrites user fields with new information.
        {
            string[] rows = System.IO.File.ReadAllLines(path);
            string filedata = "";
            foreach (string row in rows)
            {
                string[] individual = row.Split(',');
                if (individual[1] == id)
                {
                    individual[field] = data;
                }
                filedata += string.Join(",", individual) + "\n";
            }
            System.IO.File.WriteAllText(path, filedata);
        }

        public void adjustTicks(string level, string operation, int ticks)
        // Increases or decreases the tickets available in tickets.csv.
        {
            string[] rows = System.IO.File.ReadAllLines("tickets.csv");
            string newdata = rows[0];
            string[] ticketrow = rows[1].Split(',');
            if (level == "lower")
            {
                if (operation == "add")
                {
                    ticketrow[0] = (int.Parse(ticketrow[0]) + ticks).ToString();
                }
                else
                {
                    ticketrow[0] = (int.Parse(ticketrow[0]) - ticks).ToString();
                }
            }
            else if (level == "club")
            {
                if (operation == "add")
                {
                    ticketrow[1] = (int.Parse(ticketrow[1]) + ticks).ToString();
                }
                else
                {
                    ticketrow[1] = (int.Parse(ticketrow[1]) - ticks).ToString();
                }
            }
            else
            {
                if (operation == "add")
                {
                    ticketrow[2] = (int.Parse(ticketrow[2]) + ticks).ToString();
                }
                else
                {
                    ticketrow[2] = (int.Parse(ticketrow[2]) - ticks).ToString();
                }
            }
            newdata = newdata + "\n" + string.Join(",", ticketrow);
            System.IO.File.WriteAllText("tickets.csv", newdata);
        }

        public int generateConfirmationNumber()
        // Iterates through all confirmation numbers to generate a new unique confirmation number.
        {
            Random rand = new Random();
            int confirmation = rand.Next(2000, 9000);
            string[] users = System.IO.File.ReadAllLines("users.csv");
            foreach (string user in users)
            {
                string[] individual = user.Split(',');
                if (individual[10] == confirmation.ToString())
                // If confirmation number is used, try again.
                {
                    generateConfirmationNumber();
                }
            }
            return confirmation;
        }

        public int getTotalSales()
        // Find the total sales amount by adding up each user's total ticket cost.
        {
            int total = 0;
            string[] users = System.IO.File.ReadAllLines("users.csv");
            foreach (string user in users)
            {
                string[] individual = user.Split(',');
                if (individual[11] != "cost")
                {
                    total += int.Parse(individual[11]);
                }
            }
            return total;
        }

        public string getTicks(int level)
        {
            string[] rows = System.IO.File.ReadAllLines("tickets.csv");
            string[] tickets = rows[1].Split(',');
            return tickets[level];
        }

        public string[][] getCustomerData()
        // Retrieves customer data and loads into array of arrays for data table in admin page.
        {
            List<string[]> data = new List<string[]>();
            string[] users = System.IO.File.ReadAllLines("users.csv");
            foreach (string user in users)
            {
                string[] individual = user.Split(',');
                string[] individualdata = new string[7];
                individualdata[0] = individual[0];
                individualdata[1] = individual[1];
                individualdata[2] = individual[11];
                individualdata[3] = individual[10];
                individualdata[4] = individual[7];
                individualdata[5] = individual[8];
                individualdata[6] = individual[9];
                data.Add(individualdata);
            }
            return data.ToArray();
        }
    }
}
