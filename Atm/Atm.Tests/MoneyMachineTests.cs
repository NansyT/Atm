using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atm;
using Xunit;

namespace Atm.Tests
{
    public class MoneyMachineTests
    {
        //Ved ikke hvad der sker her
        
        //Hvad er det du ikke ved.... er det tagget Theory eller?
        [Theory]
        [InlineData(5000, "Bob0", 5000)]
        [InlineData(10000,"Bob2", 0)]
        [InlineData(12000,"Bob4", -2000)]
        public void WithdrawCash_ShouldWithdrawMoneyAndReturnNewBalance(double amount, string name, double expected)
        {
            //Arrange
            MoneyMachine machine = new MoneyMachine();
            //Act
            double actual = machine.WithdrawCash(amount, name);
            //Assert

            Assert.True(expected.Equals(actual));
        }

        
    }
}
