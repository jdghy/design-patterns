namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The client only interacts with the Facade
            HomeFacade home = new HomeFacade();

            home.ArriveAtHome();
            home.LeaveHome();
        }
    }
}
