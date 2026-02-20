namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cart = new ShoppingCart();

            cart.SetPaymentStrategy(new CreditCardPayment());
            cart.Checkout(100.50); // Output: Paid $100.50 using Credit Card.

            cart.SetPaymentStrategy(new PayPalPayment());
            cart.Checkout(50.00);  // Output: Paid $50.00 using PayPal.
        }
    }
}
