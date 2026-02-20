using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    // 2. Concrete Implementation: CSV
    public class CsvExporter : DataExporter
    {
        protected override void FormatData() =>
            Console.WriteLine("Formatting data as a comma-separated string (CSV).");
    }
}
