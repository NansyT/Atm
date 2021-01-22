using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atm;
using Xunit;

namespace Atm.Tests
{
    public class BankTests
    {
        
        [Theory]
        [InlineData("Bob1", "100010", "1234")]
        [InlineData("Bob0", "100000","1234")]
        [InlineData("Bob2", "100020", "1234")]
        public void GetAccount_ShouldRetrieveAccount(string name, string accountNr, string pin)
        {
            //Arrange
            Bank bank = new Bank();
            Account expected = new Account(name, accountNr, pin);
            //Act
            Account actual = bank.GetAccount(name);
            //Assert

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5000, "Bob0", 5000)]
        [InlineData(10000, "Bob1", 0)]
        [InlineData(12000, "Bob3", -2000)]
        public void UpdateBalance_ShouldUpdateAccountBalance(double amount, string name, double expected)
        {
            //Arrange
            Bank bank = new Bank();
            
            //Act
            double actual = bank.UpdateBalance(amount, name);
            //Assert

            Assert.Equal(expected, actual);
        }
        
    }
}
