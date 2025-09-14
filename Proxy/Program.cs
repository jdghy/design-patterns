namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userId = "user123";
            string documentId = "doc456";
            IDocumentAccessor documentAccessor = new SecureDocumentAccessorProxy(userId);
            try
            {
                string documentContent = documentAccessor.FetchDocument(documentId);
                Console.WriteLine(documentContent);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
