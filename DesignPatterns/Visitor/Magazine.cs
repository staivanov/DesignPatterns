using Visitor.Visitor;

namespace Visitor
{
    public class Magazine : Item, IVisitableElement
    {
        public Magazine(int id, string title, double price)
            : base(id, title, price)
        {

        }

        public void Accept(IVisitor visitor)
            => visitor.VisitMagazine(this);
    }
}
