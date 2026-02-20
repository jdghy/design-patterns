using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class Commercial : IProperty
    {
        public string BusinessName { get; set; }
        public void Accept(IVisitor visitor) => visitor.Visit(this);
    }
}
