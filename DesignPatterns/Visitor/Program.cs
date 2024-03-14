using Visitor.Visitor;

namespace Visitor
{
    public class Program
    {
        public static void Main()
        {
            List<IVisitableElement> items = new()
            {
                new Magazine(1, "Forbes", 5),
                new Book(2, "Tres metros el tielo", 15),
                new Book(3, "Lost in clouds.", 22),
                new Magazine(4, "Economic", 6),
                new Magazine(5, "Top Gear", 4)
            };

            ObjectStructure cart = new(items);
            DiscountVisitor discountVisitor = new();
            cart.ApplyVisitor(discountVisitor);

        }
    }
}
