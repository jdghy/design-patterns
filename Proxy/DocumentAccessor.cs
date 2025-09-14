using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class DocumentAccessor : IDocumentAccessor
    {
        public string FetchDocument(string documentId)
        {
            // Simulate a time-consuming operation
            System.Threading.Thread.Sleep(2000);
            return $"Document content for {documentId}";
        }
    }
}
