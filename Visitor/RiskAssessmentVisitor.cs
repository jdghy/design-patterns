using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    // 4. Concrete Visitor: Risk Assessment
    public class RiskAssessmentVisitor : IVisitor
    {
        public void Visit(Residential res) =>
            Console.WriteLine($"Assessing home risk for: {res.Address}");

        public void Visit(Commercial com) =>
            Console.WriteLine($"Assessing high-value risk for: {com.BusinessName}");
    }
}
