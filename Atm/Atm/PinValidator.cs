using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm
{
    public static class PinValidator
    {
        public static bool CheckPin(string correctPin, string enteredPin)
        {
            if (correctPin == enteredPin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
