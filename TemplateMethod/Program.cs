namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataExporter csv = new CsvExporter();
            csv.Export();

            DataExporter pdf = new PdfExporter();
            pdf.Export();
        }
    }
}
