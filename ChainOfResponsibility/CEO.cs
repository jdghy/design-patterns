using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    // 4. Concrete Handler: CEO (The end of the chain)
    public class CEO : Approver
    {
        public override void ProcessRequest(double amount)
        {
            Console.WriteLine($"{this.GetType().Name} approved purchase of {amount:C}");
        }
    }
}
