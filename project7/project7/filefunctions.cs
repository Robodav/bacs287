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
    public class FileFunctions
    {
        public FileFunctions()
        {

        }

        public void writeUser(string name, string age, string email, string password, string role)
        {
            string userInfo = "\n" + name + "," + age + "," + email + "," + password + "," + role;

            System.IO.File.AppendAllText("users.csv", userInfo);
        }

        public bool checkUser(string email)
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

        public string getPassword(string email)
        {
            string[] users = System.IO.File.ReadAllLines("users.csv");
            foreach (string user in users)
            {
                string[] individual = user.Split(',');
                if (individual[2] == email)
                {
                    return individual[3];
                }
            }

            return "";
        }
    }
}
