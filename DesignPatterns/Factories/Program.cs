using Factories.FactoryMethod;
using Factories.FactoryMethod.Factories;

namespace Factories
{
    public class Program
    {
        public static void Main()
        {
            List<DiscountFactory> factories = new()
            {
                new CodeDiscountFactory(Guid.NewGuid()),
                new CountryDiscountFactory("US")
            };


            foreach (DiscountFactory factory in factories)
            {
                DiscountService discountService = factory.CreateDiscountService();
                Console.WriteLine($"Percentage {discountService.DiscountPercentage}" +
                    $" coming from {discountService} ");
            }
        }
    }
}
