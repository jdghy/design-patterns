using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    // 1. Mediator Interface
    public interface IATCMediator
    {
        void RegisterFlight(Flight flight);
        void SendMessage(string message, Flight originator);
    }
}
