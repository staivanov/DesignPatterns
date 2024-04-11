namespace Builder
{
    public class Program
    {
        public static void Main()
        {
            HtmlBuilder builder = new("nav");
            builder.AddChild("a", "Home");
            builder.AddChild("a", "Content");
            builder.AddChild("a", "About");

            Console.WriteLine(builder.ToString());
        }
    }
}
