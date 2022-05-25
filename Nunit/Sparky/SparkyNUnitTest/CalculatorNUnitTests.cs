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
        //making the initialization for all this tests:
        private Calculator calc;
        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }


        [Test]
        public void AddNumbers_InputTwoInt_GetCorrectAddition()
        {

            //Arrange = Initialization
                //arrange is in the setup           
            //Act = Invoke the methods needed to obtain an input
            int result = calc.AddNumbers(10, 20);
            //Assert = Result expected
            Assert.AreEqual(30, result);
            
        }


        [Test]
        public void Check_odd()
        {
            //arrange is in the setup
            bool res = calc.IsOdd(43);
            Assert.IsTrue(res);
        }

        [Test]
        [TestCase(10,ExpectedResult = false)]
        [TestCase(11, ExpectedResult = true)]
        public bool IsOddChecker_InputNumber_ReturnTrueIfOdd(int a)
        {
            //arrange is in the setup
            return calc.IsOdd(a);
        }
        [Test]
        //[TestCase(5,8)] //Will check if the expected odd range is 5,7
        [TestCase(5, 9)] //Will check if the expected odd range is 5,7
        public void OddRanger_InputMinAndMax(int minimum, int maximum)
        {
            // Arrange of calculator was done before
            List<int> expectedOddRange = new() { 5, 7, 9 };
            List<int> rangeResult = calc.GetOddRange(minimum, maximum);
            Assert.That(rangeResult, Is.EquivalentTo(expectedOddRange));
            Assert.That(rangeResult, Does.Contain(7));//contains a value
            Assert.That(rangeResult, Is.Not.Empty);//not empty
            Assert.That(rangeResult.Count, Is.EqualTo(3));//isequalto
            Assert.That(rangeResult, Has.No.Member(6));//has no member
            Assert.That(rangeResult, Is.Ordered);//is ordered
            Assert.That(rangeResult, Is.Unique);// is unique
        }
    }
}
