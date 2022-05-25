using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparky
{
    public class Customer
    {
        public int Discount = 15;
        public int OrderTotal { get; set; }
        public string GreetMessage { get; set; }
        public string CombineNames(string firstName, string lastName)
        {
            //los throws siempre van desde el lado de la funcionalidad, no del lado de la prueba
            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentException("Empty First Name");
            }


            GreetMessage = $"Hello, {firstName} {lastName}";
            Discount = 20;
            return GreetMessage;
        }

        public CustomerType GetCustomerDetails()
        {
            if (OrderTotal < 100)
            {
                return new BasicCustomer();
            }
            return new PlatinumCustomer(); // if not basic customer
            

        }
    }


    public class CustomerType { }
    public class BasicCustomer : CustomerType { } //inherited from CustomerType
    public class PlatinumCustomer : CustomerType { }
}