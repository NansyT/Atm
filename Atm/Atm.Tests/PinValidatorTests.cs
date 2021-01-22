using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atm;
using Xunit;

namespace Atm.Tests
{
    public class PinValidatorTests
    {
        [Theory]
        [InlineData("1234","1234", true)]
        [InlineData("1234","12345", false)]
        [InlineData("1234","1445", false)]
        public void CheckPin_ValuesShouldBeCompared(string correct, string entered, bool expected)
        {
            //Arrange

            //Act
            bool actual = PinValidator.CheckPin(correct, entered);
            //Assert

            Assert.Equal(expected, actual);
        }
    }
}
