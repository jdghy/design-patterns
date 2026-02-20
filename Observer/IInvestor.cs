using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    // 1. The Observer Interface
    public interface IInvestor
    {
        void Update(string stockSymbol, double price);
    }
}
