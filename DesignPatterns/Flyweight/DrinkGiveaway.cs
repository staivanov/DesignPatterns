namespace Flyweight
{   //Unshared concrete Flyweight
    public class DrinkGiveaway : IDrinkFlyweight
    {
        private CoffeeSize _coffeeSize;
        private IDrinkFlyweight _randomDrink;
        public string Name { get => _randomDrink.Name; }

        private IDrinkFlyweight[] _eligibleDrinks =
        [
            new Espresso(),
            new Latte()
        ];

        public DrinkGiveaway()
        {
            int randomIndex = new Random().Next(0, 2);
            _randomDrink = _eligibleDrinks[randomIndex];
        }

        //Extrinsic state
        public void Serve(CoffeeSize size)
        {
            _coffeeSize = size;
            Console.WriteLine($"Giveaway!");
            Console.WriteLine($"-- {size} {_randomDrink.Name} is coming up!");

        }
    }
}
