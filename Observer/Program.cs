namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var apple = new Stock("AAPL", 150.00);
            var sorros = new Investor { Name = "Sorros" };

            apple.Attach(sorros);
            apple.Price = 155.50; // Trigger notification
        }
    }
}
