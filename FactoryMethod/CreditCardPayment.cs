using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class CreditCardPayment:IPayment
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing credit card payment of {amount}");
        }
    }
    
}
