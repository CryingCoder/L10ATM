using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMLab
{
    internal class ATM
    {

        public List<Access> Users { get; set; }
        public Access CurrentUser { get; set; }

        
        public void Deposit(Access currentUser)
        {
            
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.setBalance(deposit);

        }

        public void withdrawal(Access currentUser)
        {
            Console.WriteLine("How much would you like to withdraw?");
            double withdrawal = Double.Parse(Console.ReadLine());
            if (currentUser.getBalance() > withdrawal)
            {
                Console.WriteLine("The amount entered is more than what's available");
            }
            else
            {
                double newBalance = currentUser.getBalance() - withdrawal;
                Console.WriteLine($"You're Withdrawing: {withdrawal}");
            }
        }

       public void Balance(Access currentUser)
        {
            Console.WriteLine("Currrent Balance :" + currentUser.getBalance());
        }
    }
}
