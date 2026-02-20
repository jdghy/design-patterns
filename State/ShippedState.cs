using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class ShippedState : IOrderState
    {
        public void ProcessOrder(OrderContext context)
        {
            Console.WriteLine("Order is already shipped. Updating tracking...");
            context.TransitionTo(new DeliveredState());
        }
    }
}
