using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm
{
    public class MoneyMachine
    {
        
        Bank bank = new Bank();

        private bool CheckAccount(string correctPin, string enteredPin)
        {
            return PinValidator.CheckPin(correctPin, enteredPin);
        }
        public bool GetAccount(string name, string enteredPin)
        {
            Account temp = bank.GetAccount(name);
            if (CheckAccount(temp.Pin, enteredPin) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
        public double WithdrawCash(double amount, string name)
        {
            return bank.UpdateBalance(amount, name);
        }
    }
}
