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
            CreateAccounts();
        }
        private void UpdateBalance(double amount, string accountNr)
        {

        }

        public string GetAccount(string name)
        {
            return "";
        }

        private void CreateAccounts()
        {
            int numb =  100000;
            for (int i = 0; i < 5; i++)
            {
                accounts.Add(new Account("Bob" + i.ToString(), numb.ToString(), "1234"));
                numb += 10;
            }
        }
    }
}
