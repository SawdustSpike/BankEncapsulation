using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double balance = 0;
        public BankAccount()
        {
        }
        public void Deposit(double add)
        {
            balance += add;
            Console.WriteLine($"you've added ${add} into your account for a new total balance of ${balance}");
        }
        public double GetBalance()
        {
            return balance;
        }

    }

}
