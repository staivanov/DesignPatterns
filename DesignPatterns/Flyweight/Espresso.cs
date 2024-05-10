namespace Flyweight
{
    public class Espresso : IDrinkFlyweight
    {
        private string _name;
        public string Name { get => _name; }
        private readonly IEnumerable<string> _ingredients;

        public Espresso()
        {
            _name = "Espresso";
            _ingredients =
            [
               "Cuban coffee beans",
               "Steamed milk"
            ];
        }

        public void Serve(CoffeeSize size)
            => Console.WriteLine($" -- {size} {_name} with {string.Join(" and ", _ingredients)} is comming up!");
    }
}
