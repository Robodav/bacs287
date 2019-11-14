using System;

namespace project7
{
    public class FileFunctions
    {
        public FileFunctions()
        {

        }

        public void writeUser(string name, string age, string email, string password, string role) // writes a new user to users.csv
        {
            string userInfo = "\n" + name + "," + age + "," + email + "," + password + "," + role;
            userInfo += ",0,0,0,0,0,0,0,0";
            System.IO.File.AppendAllText("users.csv", userInfo);
        }

        public bool checkUser(string email) // checks if a user exists in users.csv
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

        public string getField(string email, int field) // returns value of index field for user based on specified email from users.csv
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
    }
}
