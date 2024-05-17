namespace Proxy
{
    /// <summary>
    /// Real Subject
    /// </summary>
    public class Document : IDocument
    {
        private string _fileName;
        public string Title { get; set; }
        public string Content { get; set; }
        public int AuthorId { get; set; }
        public DateTimeOffset LastAccesed { get; private set; }

        public Document(string fileName)
        {
            _fileName = fileName;
            LoadDocument(fileName);
        }


        private void LoadDocument(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentException($"'{nameof(fileName)}' cannot be null or empty.", nameof(fileName));
            }

            fileName = $"C:\\Intel\\system213";
            Console.WriteLine($"Loading a file from {fileName}");
            Thread.Sleep(500);

            Title = "Very important document";
            Content = "Dream big. Dare to dream big, because everything is possible!";
            AuthorId = 1;
            LastAccesed = DateTimeOffset.UtcNow;
        }

        public void DisplayDocument()
          => Console.WriteLine($"Title: {Title} - Content: {Content}");
    }
}
