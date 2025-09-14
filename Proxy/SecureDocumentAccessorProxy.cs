using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class SecureDocumentAccessorProxy:IDocumentAccessor
    {
        private DocumentAccessor _documentAccessor;
        private readonly string _userId;

        public SecureDocumentAccessorProxy(string userId)
        {
            _userId = userId;
            _documentAccessor = new DocumentAccessor();
        }

        public string FetchDocument(string documentId)
        {
            if (IsUserAuthorized(_userId, documentId))
            {
                LogAccess(_userId, documentId);
                return _documentAccessor.FetchDocument(documentId);
            }
            else
            {
                throw new UnauthorizedAccessException("User is not authorized to access this document.");
            }
        }

        private bool IsUserAuthorized(string userId, string documentId)
        {
            // Simulate an authorization check
            return true; // Assume all users can access documents
        }
        private void LogAccess(string userId, string documentId)
        {
            // Simulate logging access
            Console.WriteLine($"User {userId} accessed document {documentId} at {DateTime.Now}");
        }
    }
}
