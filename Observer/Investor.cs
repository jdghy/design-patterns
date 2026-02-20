using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{

    // 3. Concrete Observer
    public class Investor : IInvestor
    {
        public string Name { get; set; }
        public void Update(string stockSymbol, double price)
        {
            Console.WriteLine($"Notified {Name}: {stockSymbol} changed to {price:C}");
        }
    }
}
