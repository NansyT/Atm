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
        [InlineData("Bob1", "100010")]
        [InlineData("Bob0", "100000")]
        [InlineData("Bob2", "100020")]
        public void GetAccount_ShouldRetrieveAccount(string name, string expected)
        {
            //Arrange
            Bank bank = new Bank();
            //Act
            string actual = bank.GetAccount(name);
            //Assert

            Assert.Equal(expected, actual);
        }

        
    }
}
