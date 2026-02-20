using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    // 2. Concrete Strategies
    public class CreditCardPayment : IPaymentStrategy
    {
        public void ProcessPayment(double amount) =>
            Console.WriteLine($"Paid {amount:C} using Credit Card.");
    }
}
