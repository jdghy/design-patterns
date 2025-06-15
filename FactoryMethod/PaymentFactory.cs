using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class PaymentFactory
    {
        //best practice for factory class is to use a static method to create instances.It allows for easy access without needing to instantiate the factory class itself.
        public static IPayment CreatePayment(PaymentMethod paymentMethod)
        {
            //return paymentMethod switch
            //{
            //    PaymentMethod.CreditCard => new CreditCardPayment(),
            //    PaymentMethod.PayPal => new PayPalPayment(),
            //    PaymentMethod.GooglePay => new GooglePayPayment(),
            //    _ => throw new ArgumentException("Invalid payment method")
            //};

            switch (paymentMethod)
            {
                case PaymentMethod.CreditCard:
                    return new CreditCardPayment();
                case PaymentMethod.PayPal:
                    return new PayPalPayment();
                case PaymentMethod.GooglePay:
                    return new GooglePayPayment();
                default:
                    throw new ArgumentException("Invalid payment method");
            }
        }
    }
}
