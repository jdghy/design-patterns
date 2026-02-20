using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    // 3. The Visitor Interface
    public interface IVisitor
    {
        void Visit(Residential residential);
        void Visit(Commercial commercial);
    }
}
