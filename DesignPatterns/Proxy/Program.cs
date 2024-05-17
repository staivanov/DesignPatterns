namespace Proxy
{
    public class Program
    {
        public static void Main()
        {
            Document document = new("important");
            document.DisplayDocument();
            Console.WriteLine();
            DocumentProxy documentProxy = new("possible");
            documentProxy.DisplayDocument();
            Console.WriteLine();
            //Chained proxy with access
            ProtectedDocumentProxy protectedDocumentProxy = new("veryImportant", "Viewer");
            protectedDocumentProxy.DisplayDocument();
            Console.WriteLine();
            //Chained proxy with no access
            ProtectedDocumentProxy protectedDocumentProxyNoAccess = new("veryImportant", "NotRegistred");
            //Code below will throw exception
            //protectedDocumentProxyNoAccess.DisplayDocument();
        }
    }
}
