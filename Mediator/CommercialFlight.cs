using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    // 4. Concrete Colleague
    public class CommercialFlight : Flight
    {
        public CommercialFlight(IATCMediator mediator, string flightNumber)
            : base(mediator, flightNumber) { }

        public void RequestLanding()
        {
            Console.WriteLine($"{FlightNumber} requesting landing clearance.");
            _mediator.SendMessage("Requesting landing.", this);
        }

        public override void Receive(string message) =>
            Console.WriteLine($"{FlightNumber} received message -> {message}");
    }
}
