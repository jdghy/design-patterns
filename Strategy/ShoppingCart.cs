using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    // 3. The Context
    public class ShoppingCart
    {
        private IPaymentStrategy _paymentStrategy;

        // Strategy is usually injected via constructor or setter
        public void SetPaymentStrategy(IPaymentStrategy strategy)
        {
            _paymentStrategy = strategy;
        }

        public void Checkout(double amount)
        {
            if (_paymentStrategy == null)
            {
                Console.WriteLine("Please select a payment method.");
                return;
            }
            _paymentStrategy.ProcessPayment(amount);
        }
    }
}
