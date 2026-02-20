using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    // 1. The State Interface
    public interface IOrderState
    {
        void ProcessOrder(OrderContext context);
    }
}
