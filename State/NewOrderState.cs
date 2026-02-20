using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    // 2. Concrete States
    public class NewOrderState : IOrderState
    {
        public void ProcessOrder(OrderContext context)
        {
            Console.WriteLine("Processing payment for new order...");
            context.TransitionTo(new ShippedState());
        }
    }
}
