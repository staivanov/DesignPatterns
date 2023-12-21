namespace Strategy
{
    public class Program
    {
        static void Main()
        {
            TextProcessor textProcessor = new();
            textProcessor.SetOutPutFormat(OutputFormat.HTML);
            IEnumerable<string> rappers = new[] { "Snoop Dogg", "Dr.Dre", "Eminem" };
            textProcessor.AppendList(rappers);
            Console.WriteLine(textProcessor.ToString());
            textProcessor.Clear();

            textProcessor.SetOutPutFormat(OutputFormat.Markdown);
            textProcessor.AppendList(rappers);
            Console.WriteLine(textProcessor.ToString());
        }
    }
}
