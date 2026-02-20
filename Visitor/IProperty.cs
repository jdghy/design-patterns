using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    // 1. The Element Interface
    public interface IProperty
    {
        void Accept(IVisitor visitor);
    }
}
