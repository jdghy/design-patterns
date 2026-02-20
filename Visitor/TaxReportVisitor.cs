using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    // 5. Concrete Visitor: Tax Report
    public class TaxReportVisitor : IVisitor
    {
        public void Visit(Residential res) =>
            Console.WriteLine($"Calculating residential property tax for {res.Address}");

        public void Visit(Commercial com) =>
            Console.WriteLine($"Calculating business tax for {com.BusinessName}");
    }
}
