namespace RulesEngine.RulesCollection
{
    public interface IDiscountRule
    {
        decimal CalculateDiscount(Customer customer, decimal? currentDiscount);
    }
}
