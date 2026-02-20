using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    // 1. The Abstract Class (The Blueprint)
    public abstract class DataExporter
    {
        // The Template Method - defines the workflow structure
        public void Export()
        {
            ReadData();
            FormatData(); // Step to be overridden
            SaveToFile();
        }

        private void ReadData() => Console.WriteLine("Reading data from SQL Server...");

        protected abstract void FormatData(); // Subclasses MUST implement this

        private void SaveToFile() => Console.WriteLine("File saved to disk.\n");
    }

}
