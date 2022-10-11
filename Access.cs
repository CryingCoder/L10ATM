using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMLab
{
    internal class Access

        {
            public String Name { get; set; }
            public double Balance { get; set; }
            public String Password { get; set; }
            public string ATMMenu { get; set; }

            public Access(string Name, string Password, double Balance)
            {
                this.Name = Name;
                this.Password = Password;
                this.Balance = Balance;
            }

            public String getName()
            {
                return Name;
            }

            public String getPassword()
            {
                return Password;
            }

            public double getBalance()
            {
                return Balance;
            }

            public void setName(String newName)
            {
                Name = newName;
            }

            public void setPassword(String newPassword)
            {
                Password = newPassword;
            }

            public void setBalance(double newBalance)
            {
                Balance = newBalance;
            }
    }
}
