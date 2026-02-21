using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    // 1. The Handler Interface/Base Class
    public abstract class Approver
    {
        protected Approver Successor;

        public void SetSuccessor(Approver successor)
        {
            Successor = successor;
        }

        public abstract void ProcessRequest(double amount);
    }
}
