using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    // 3. Concrete Implementation: PDF
    public class PdfExporter : DataExporter
    {
        protected override void FormatData() =>
            Console.WriteLine("Generating PDF tables and headers.");
    }
}
