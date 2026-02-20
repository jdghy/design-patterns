namespace Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            user.Compute('+', 100); // Output: 100
            user.Compute('+', 50);  // Output: 150
            user.Undo();            // Output: 100
        }
    }
}
