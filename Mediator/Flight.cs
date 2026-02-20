using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    // 2. Colleague (Base Class)
    public abstract class Flight
    {
        protected IATCMediator _mediator;
        public string FlightNumber { get; }

        public Flight(IATCMediator mediator, string flightNumber)
        {
            _mediator = mediator;
            FlightNumber = flightNumber;
        }

        public abstract void Receive(string message);
    }
}
