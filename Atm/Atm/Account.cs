using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm
{
    class Account
    {
        private string accountHolder;

        public string AccountHolder
        {
            get { return accountHolder; }
            set { accountHolder = value; }
        }
        private string accountNr;

        public string AccountNr
        {
            get { return accountNr; }
            set { accountNr = value; }
        }
        private double balance;

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        private string pin;

        public string Pin
        {
            get { return pin; }
            set { pin = value; }
        }

        public Account(string accountHolder, string accountNr, string pin)
        {
            AccountHolder = accountHolder;
            AccountNr = accountNr;
            Balance = 10000;
            Pin = pin;
        }
    }
}
