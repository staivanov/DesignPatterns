using Visitor.Visitor;

namespace Visitor
{
    public class DiscountVisitor : IVisitor
    {
        private static double _savedSum = 0;

        public void VisitBook(Book book)
        {
            double bookDiscount = book.GetDiscount(0.1);

            if (book.Price < 15)
            {
                Console.WriteLine("Discount!");
                Console.WriteLine($"Book ID: {book.Id} | Name {book.Title} | Price ${Math.Round(book.Price - bookDiscount, 2)}.");
            }
            else
            {
                Console.WriteLine("Full Price!");
                Console.WriteLine($"Book ID: {book.Id} | Name {book.Title} | Price ${Math.Round(book.Price, 2)}.");
            }

            _savedSum += bookDiscount;
        }

        public void VisitMagazine(Magazine magazine)
        {
            double magazineDiscount = magazine.GetDiscount(0.01);

            if (magazine.Price < 10)
            {
                Console.WriteLine("Discount!");
                Console.WriteLine($"Book ID: {magazine.Id} | Name {magazine.Title} | Price ${Math.Round(magazine.Price - magazineDiscount, 2)}.");
            }
            else
            {
                Console.WriteLine("Full Price!");
                Console.WriteLine($"Book ID: {magazine.Id} | Name {magazine.Title} | Price ${Math.Round(magazine.Price, 2)}.");
            }

            _savedSum += magazineDiscount;
        }

        public void Print()
        {
            Console.WriteLine($"You saved ${Math.Round(_savedSum),2} on your order!");
            Reset();
        }

        private static void Reset()
            => _savedSum = 0.0;
    }
}
