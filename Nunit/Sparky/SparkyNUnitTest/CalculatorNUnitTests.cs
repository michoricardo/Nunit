using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparky
{
    [TestFixture]
    public class CalculatorNUnitTests
    {
        [Test]
        public void AddNumbers_InputTwoInt_GetCorrectAddition()
        {

            //Arrange = Initialization
            Calculator calc = new();
            //Act = Invoke the methods needed to obtain an input
            int result = calc.AddNumbers(10, 20);
            //Assert = Result expected
            Assert.AreEqual(30, result);
            
        }
    }
}
