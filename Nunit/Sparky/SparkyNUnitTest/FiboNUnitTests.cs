using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparky
{
    [TestFixture]
    public class FiboNUnitTests
    {
        
        private Fibo fibonacci;
        [SetUp]
        public void Setup()
        {
            fibonacci = new Fibo();
        }
        [Test]
        public void FiboChecker_1()
        {
            fibonacci.Range = 1;
            List<int> expectedRange = new() { 0 };
            List<int> result = fibonacci.GetFiboSeries();
            Assert.That(result, Is.Not.Empty);
            Assert.That(result, Is.Ordered);
            Assert.That(result,Is.EquivalentTo(expectedRange));
        }
        [Test]
        public void FiboChecker_6()
        {
            fibonacci.Range = 6;
            List<int> expectedRange = new() { 0,1,1,2,3,5 };
            List<int> result = fibonacci.GetFiboSeries();
            //Assert.That(result, Contains.Value(3));
            Assert.That(result.Count(), Is.EqualTo(6));
            Assert.That(result,Has.No.Member(4));
            Assert.That(result, Is.EquivalentTo(expectedRange));
        }

    }
}
