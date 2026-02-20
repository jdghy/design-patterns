using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    // 2. Concrete Elements
    public class Residential : IProperty
    {
        public string Address { get; set; }
        // Double Dispatch: The element directs the visitor to its specific method
        public void Accept(IVisitor visitor) => visitor.Visit(this);
    }
}
