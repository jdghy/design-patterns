namespace State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var order = new OrderContext(new NewOrderState());
            order.Request(); // Transitions to Shipped
            order.Request(); // Transitions to Delivered
        }
    }
}
