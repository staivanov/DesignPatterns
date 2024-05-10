namespace Flyweight
{
    public class Latte : IDrinkFlyweight
    {
        private string _name;
        public string Name { get => _name; }
        private readonly IEnumerable<string> _ingredients;
        
        public Latte()
        {
            _name = "Latte";
            _ingredients =
            [
                "Brazil coffee beans",
                "Hot water",
            ];
        }

        public void Serve(CoffeeSize size)
            => Console.WriteLine($" -- {size} {_name} with {string.Join(" and ", _ingredients)} is comming up!");
    }
}
