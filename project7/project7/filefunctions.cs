using System;

namespace project7
{
    public class FileFunctions
    {
        public FileFunctions()
        {

        }

        public void writeUser(string name, string age, string email, string password, string role) 
        // Writes a new user to users.csv.
        {
            string userInfo = "\n" + name + "," + age + "," + email + "," + password + "," + role;
            userInfo += ",0,0,0,0,0,0,0,0";
            System.IO.File.AppendAllText("users.csv", userInfo);
        }

        public bool checkUser(string email) 
        // Checks if a user exists in users.csv.
        {
            string[] users = System.IO.File.ReadAllLines("users.csv");
            foreach (string user in users)
            {
                string[] individual = user.Split(',');
                if (individual[2] == email)
                {
                    return true;
                }
            }

            return false;
        }

        public string getField(string email, int field) 
        // Returns value of index field for user based on specified email from users.csv.
        {
            string[] users = System.IO.File.ReadAllLines("users.csv");
            foreach (string user in users)
            {
                string[] individual = user.Split(',');
                if (individual[2] == email)
                {
                    return individual[field];
                }
            }
            return "User not found!";
        }

        public void writeField(string email, int field, string data)
        // Overwrites users.csv with new information.
        {
            string[] users = System.IO.File.ReadAllLines("users.csv");
            string filedata = "";
            foreach (string user in users)
            {
                string[] individual = user.Split(',');
                if (individual[2] == email)
                {
                    individual[field] = data;
                }
                filedata += string.Join(",", individual) + "\n";
            }
            System.IO.File.WriteAllText("users.csv", filedata);
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
                if (individual[11] == confirmation.ToString())
                // If confirmation number is used, try again.
                {
                    generateConfirmationNumber();
                }
            }
            return confirmation;
        }
    }
}
