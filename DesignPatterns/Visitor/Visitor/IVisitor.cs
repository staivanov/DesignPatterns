namespace Visitor.Visitor
{
    public interface IVisitor
    {
        void VisitMagazine(Magazine magazine);
        void VisitBook(Book book);
        void Print();
    }
}
