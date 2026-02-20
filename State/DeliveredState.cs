using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class DeliveredState : IOrderState
    {
        public void ProcessOrder(OrderContext context)
        {
            Console.WriteLine("Order delivered. No further processing.");
        }
    }
}
