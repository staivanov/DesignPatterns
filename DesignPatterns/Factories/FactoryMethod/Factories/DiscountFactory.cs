namespace Factories.FactoryMethod.Factories
{
    /// <summary>
    /// Creator / Factory method
    /// </summary>
    public abstract class DiscountFactory
    {
        public abstract DiscountService CreateDiscountService();
    }
}
