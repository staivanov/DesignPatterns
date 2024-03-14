using Visitor.Visitor;

namespace Visitor
{
    public class Book : Item, IVisitableElement
    {
        public Book(int id, string title, double price)
            : base(id, title, price)
        {

        }

        public void Accept(IVisitor visitor)
            => visitor.VisitBook(this);
    }
}
