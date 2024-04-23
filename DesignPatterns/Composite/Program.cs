using CompositeDesignPattern.Structural;

namespace CompositeDesignPattern
{
    public class Program
    {
        /// <summary>
        /// Client
        /// </summary>
        public static void Main()
        {
            Composite root = new("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            Composite compositeOne = new("Composite C1");
            compositeOne.Add(new Leaf("Leaf C1-A"));
            compositeOne.Add(new Leaf("Leaf C1-B"));

            Composite compositeTwo = new("Composite C2");
            compositeTwo.Add(new Leaf("Leaf C2-A"));
            compositeOne.Add(compositeTwo);

            root.Add(compositeOne);
            root.Add(new Leaf("Leaf C"));

            Leaf leafD = new("Leaf D");
            root.Add(leafD);
            root.Remove(leafD);

            root.PrimaryOperation(1);
        }
    }
}
