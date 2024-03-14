namespace Visitor
{
    public class Item
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }


        public Item(int id, string title, double price)
        {
            Id = id;
            Title = title;
            Price = price;
        }

        public double GetDiscount(double percentage)
               => Math.Round(Price * percentage, 2);
    }
}
