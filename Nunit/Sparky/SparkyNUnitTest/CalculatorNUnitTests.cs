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


        [Test]
        public void Check_odd()
        {
            Calculator calc2 = new();
            bool res = calc2.IsOdd(43);
            Assert.IsTrue(res);
        }

        [Test]
        [TestCase(10,ExpectedResult = false)]
        [TestCase(11, ExpectedResult = true)]
        public bool IsOddChecker_InputNumber_ReturnTrueIfOdd(int a)
        {
            Calculator calc = new();
            return calc.IsOdd(a);
        }
    }
}
