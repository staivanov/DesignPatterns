namespace Factories.FactoryMethod.Discounts
{
    /// <summary>
    /// Concrete Product
    /// </summary>
    public class CodeDiscount : DiscountService
    {
        private readonly Guid _code;

        public CodeDiscount(Guid code)
                => code = code;

        public override int DiscountPercentage
        {
            get => 15;
        }
    }
}
