namespace Strategy
{
    public class Program
    {
        static void Main()
        {
            TextProcessor textProcessor = new();
            textProcessor.SetOutputFormat(OutputFormat.HTML);
            IEnumerable<string> rappers = new[] { "Snoop Dogg", "Dr.Dre", "Eminem" };
            textProcessor.AppendList(rappers);
            Console.WriteLine(textProcessor.ToString());
            textProcessor.Clear();

            textProcessor.SetOutputFormat(OutputFormat.Markdown);
            textProcessor.AppendList(rappers);
            Console.WriteLine(textProcessor.ToString());
        }
    }
}
