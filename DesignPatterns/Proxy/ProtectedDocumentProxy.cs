using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class ProtectedDocumentProxy : IDocument
    {
        private string _fileName;
        private string _userRole;
        private DocumentProxy _documentProxy;
        private string viewer = "Viewer";

        public ProtectedDocumentProxy(string fileName, string userRole)
        {
            _fileName = fileName;
            _userRole = userRole;
            _documentProxy = new DocumentProxy(_fileName);
            
        }

        public void DisplayDocument()
        {
            Console.WriteLine($"*** Displaying document from {nameof(ProtectedDocumentProxy)} ***");

            if (_userRole != viewer)
            {
                throw new UnauthorizedAccessException();
            }

            _documentProxy.DisplayDocument();

            Console.WriteLine($"*** Exiting document from {nameof(ProtectedDocumentProxy)} ***");
        }
    }
}
