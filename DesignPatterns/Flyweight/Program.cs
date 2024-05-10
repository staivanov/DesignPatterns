namespace Flyweight
{
    public class Program
    {
        public static void Main()
        {
            DrinkFactory drinkFactory = new();
            drinkFactory.ListDrinks();

            string latte = "Latte",
                   espresso = "Espresso";
            CoffeeSize medium = CoffeeSize.Medium,
                       large = CoffeeSize.Large;

            IDrinkFlyweight myLatte = drinkFactory.GetDrink(latte);
            myLatte.Serve(medium);
            IDrinkFlyweight myEspresso = drinkFactory.GetDrink(espresso);
            myEspresso.Serve(large);


        }
    }
}
