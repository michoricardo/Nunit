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
        //[TestCase("Alexa", "Speaker")]
        //[TestCase("Alexa", "Garci")]
        
        public void CombineName_InputFirstAndLastName_ReturnFullName(string word1,string word2)
        {
            Customer customer1 = new Customer();
            string fullNameVariable = customer1.CombineNames(word1, word2);

            Assert.Multiple(() =>
            {
                Assert.That(fullNameVariable, Is.EqualTo("Hello, Richard Garci"));
                Assert.AreEqual(fullNameVariable, "Hello, Richard Garci");
                Assert.That(fullNameVariable, Does.Contain(",")); //contain
                Assert.That(fullNameVariable, Does.StartWith("Hello,"));//StartWith
                Assert.That(fullNameVariable, Does.StartWith("hELLo").IgnoreCase);
                Assert.That(fullNameVariable, Does.EndWith("Garci"));
                Assert.That(fullNameVariable, Does.Match("Hello, [A-Z]{1}[a-z]+ [A-Z]{1}[a-z]")); //Match
            }); //From assert multiple 
        }

        [Test]
        public void DiscountCheck()
        {
            Customer cust = new Customer();
            int discResult = cust.Discount;
            Assert.That(discResult, Is.InRange(10, 30));
        }

        [Test]
        public void EmptyLastName() //it checks the fact that it is not empty but not the exception we declared on Customer.cs
        {
            Customer cust3 = new Customer();
            cust3.CombineNames("Richard", "");
            Assert.IsNotNull(cust3.GreetMessage);
            Assert.IsFalse(string.IsNullOrEmpty(cust3.GreetMessage));
        }


        [Test]
        public void ExceptionChecker()
        {
            Customer cust4 = new Customer();
            var exceptionDetails = Assert.Throws<ArgumentException>(() => cust4.CombineNames("", "Garci"));
            Assert.AreEqual("Empty First Name",exceptionDetails.Message);
            //another method
            Assert.That(() => cust4.CombineNames("", "Garci"), Throws.ArgumentException.With.Message.EqualTo("Empty First Name"));
            //Throws argument exception, no matter message
            Assert.That(() => cust4.CombineNames("", "Garci"), Throws.ArgumentException);
        }

        [Test]

        public void CustomerTypeCheck() 
        {
            Customer cust5 = new Customer();
            cust5.OrderTotal = 10;
            var result = cust5.GetCustomerDetails();
            Assert.That(result, Is.TypeOf<BasicCustomer>()); //Checks if the customer is type of basic 

        }


    }
}
