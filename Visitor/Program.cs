namespace Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var properties = new List<IProperty> {
            new Residential { Address = "123 Maple St" },
            new Commercial { BusinessName = "Tech Corp" }
            };

            var riskVisitor = new RiskAssessmentVisitor();
            foreach (var p in properties) p.Accept(riskVisitor);
        }
    }
}
