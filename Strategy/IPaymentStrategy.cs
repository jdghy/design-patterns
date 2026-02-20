using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    // 1. The Strategy Interface
    public interface IPaymentStrategy
    {
        void ProcessPayment(double amount);
    }
}
