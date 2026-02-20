using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    // 3. The Context (Main Object)
    public class OrderContext
    {
        private IOrderState _state;

        public OrderContext(IOrderState initialState)
        {
            _state = initialState;
        }

        public void TransitionTo(IOrderState state)
        {
            _state = state;
            Console.WriteLine($"State changed to: {_state.GetType().Name}");
        }

        public void Request()
        {
            _state.ProcessOrder(this);
        }
    }
}
