namespace Flyweight
{
    public class DrinkFactory
    {
        private Dictionary<string, IDrinkFlyweight> _drinkChache = [];
        public Dictionary<string, IDrinkFlyweight> DrinkChache { get => _drinkChache; set => _drinkChache = value; }
        public int ObjectCreated;

        public IDrinkFlyweight GetDrink(string drinkKey)
        {
            IDrinkFlyweight drink;
            bool isKeyAvailable = _drinkChache.ContainsKey(drinkKey);

            if (isKeyAvailable)
            {
                Console.WriteLine("Reusing existing flyweight objects.");
                return _drinkChache[drinkKey];
            }
            else
            {
                Console.WriteLine("Creating new flyweight object.");

                drink = drinkKey switch
                {
                    "Espresso" => new Espresso(),
                    "Latte" => new Latte(),
                    _ => throw new Exception("This is not a flyweight object."),
                };

                _drinkChache.Add(drinkKey, drink);
                ObjectCreated++;

                return drink;
            }
        }

        public IDrinkFlyweight CreateGiveAway()
            => new DrinkGiveaway();

        public void ListDrinks()
        {
            Console.WriteLine($"Factory has {_drinkChache.Count} drinks object.");

            foreach (KeyValuePair<string, IDrinkFlyweight> drink in _drinkChache)
            {
                Console.WriteLine(drink.Value.Name);
            }
        }
    }
}
