namespace ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var larry = new Manager();
            var sam = new Director();
            var tammy = new CEO();

            // Set the chain: Manager -> Director -> CEO
            larry.SetSuccessor(sam);
            sam.SetSuccessor(tammy);

            larry.ProcessRequest(800);   // Handled by Manager
            larry.ProcessRequest(3500);  // Handled by Director
            larry.ProcessRequest(15000); // Handled by CEO
        }
    }
}
