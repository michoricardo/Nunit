using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparky
{
    [TestFixture]
    public class CustomerNUnitTests
    {
        [Test]
        [TestCase("Richard","Garci")]
        [TestCase("Alexa", "Speaker")]
        [TestCase("Alexa", "Garci")]
        
        public void CombineName_InputFirstAndLastName_ReturnFullName(string word1,string word2)
        {
            Customer customer1 = new Customer();
            string fullNameVariable = customer1.CombineNames(word1, word2);
            Assert.That(fullNameVariable, Is.EqualTo("Hello, Richard Garci"));
            Assert.AreEqual(fullNameVariable,"Hello, Richard Garci");
            Assert.That(fullNameVariable, Does.Contain(",")); //contain
            Assert.That(fullNameVariable, Does.StartWith("Hello,"));//StartWith
            Assert.That(fullNameVariable, Does.EndWith("Garci"));
            Assert.That(fullNameVariable, Does.Match("Hello, [A-Z]{1}[a-z]+ [A-Z]{1}[a-z]")); //Match
            
        }

    }
}
