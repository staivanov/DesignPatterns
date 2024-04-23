using CompositeDesignPattern.Example;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;

namespace CompositeDesignPattern
{
    public class Program
    {
        /// <summary>
        /// Client
        /// </summary>
        public static void Main()
        {
            //Composite root = new("root");
            //root.Add(new Leaf("Leaf A"));
            //root.Add(new Leaf("Leaf B"));

            //Composite compositeOne = new("Composite C1");
            //compositeOne.Add(new Leaf("Leaf C1-A"));
            //compositeOne.Add(new Leaf("Leaf C1-B"));

            //Composite compositeTwo = new("Composite C2");
            //compositeTwo.Add(new Leaf("Leaf C2-A"));
            //compositeOne.Add(compositeTwo);

            //root.Add(compositeOne);
            //root.Add(new Leaf("Leaf C"));

            //Leaf leafD = new("Leaf D");
            //root.Add(leafD);
            //root.Remove(leafD);

            //root.PrimaryOperation(1);

            var builder = new FileSystemBuilder("development");
            builder.AddDirectory("projectOne");
            builder.AddFile("p1f1.txt", 2100);
            builder.AddFile("p1f1.txt", 3100);
            builder.AddDirectory("sub-dir");
            builder.AddFile("p1f3.txt", 4100);
            builder.AddFile("p1f4.txt", 5100);

            builder.SetCurrentDirectory("development");
            builder.AddDirectory("project2");
            builder.AddFile("p2f1.txt", 6100);
            builder.AddFile("p2f2.txt", 7100);

            string result = JsonConvert.SerializeObject(builder.Root, Formatting.Indented);
            Console.WriteLine(result);
        }
    }
}
