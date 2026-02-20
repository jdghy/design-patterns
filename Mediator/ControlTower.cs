using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    // 3. Concrete Mediator
    public class ControlTower : IATCMediator
    {
        private List<Flight> _flights = new List<Flight>();

        public void RegisterFlight(Flight flight) => _flights.Add(flight);

        public void SendMessage(string message, Flight originator)
        {
            foreach (var flight in _flights)
            {
                // Mediator decides who receives the message
                if (flight != originator)
                {
                    flight.Receive($"{originator.FlightNumber}: {message}");
                }
            }
        }
    }
}
