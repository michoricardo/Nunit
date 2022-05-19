using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sparky;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
  

namespace SparkyMsTest
{
    [TestClass]
    public class CalculatorMSTests
    {
        [TestMethod]
        public void AddNumbers_InputTwoInt_GetCorrectAddition()
        {
            
            //Arrange = Initialization
            Calculator calc = new();
            //Act = Invoke the methods needed to obtain an input
            int result = calc.AddNumbers(10, 20);
            //Assert = Result expected
            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void Check_odd()
        {
            Calculator calc2 = new();
            bool res = calc2.IsOdd(43);
            Assert.IsTrue(res);
            
            
           
        }
    }
}
