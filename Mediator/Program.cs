namespace Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tower = new ControlTower();
            var flight1 = new CommercialFlight(tower, "AA123");
            var flight2 = new CommercialFlight(tower, "UA456");

            tower.RegisterFlight(flight1);
            tower.RegisterFlight(flight2);

            flight1.RequestLanding();
        }
    }
}
