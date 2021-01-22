using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm
{
    public class Bank
    {
        private List<Account> accounts;

        public Bank()
        {
            accounts = CreateAccounts();
        }
        public double UpdateBalance(double amount, string name)
        {
            double balance = GetAccount(name).Balance;
            double newBal = balance - amount;
            GetAccount(name).Balance = newBal;
            return newBal;
        }

        public Account GetAccount(string name)
        {
            foreach (var item in accounts)
            {
                if (item.AccountHolder == name)
                {
                    return item;
                }
            }
            return null;
        }

        private List<Account> CreateAccounts()
        {
            List<Account> temp = new List<Account>();
            int numb =  100000;
            for (int i = 0; i < 5; i++)
            {
                temp.Add(new Account("Bob" + i.ToString(), numb.ToString(), "1234"));
                numb += 10;
            }
            return temp;
        }
    }
}
