namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPayment paymentMethod = PaymentFactory.CreatePayment(PaymentMethod.CreditCard);
            paymentMethod.ProcessPayment(100.00);   
        }
    }
}
