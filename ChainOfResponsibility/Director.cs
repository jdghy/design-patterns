using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    // 3. Concrete Handler: Director
    public class Director : Approver
    {
        public override void ProcessRequest(double amount)
        {
            if (amount < 5000)
            {
                Console.WriteLine($"{this.GetType().Name} approved purchase of {amount:C}");
            }
            else if (Successor != null)
            {
                Successor.ProcessRequest(amount); // Pass it up
            }
        }
    }
}
