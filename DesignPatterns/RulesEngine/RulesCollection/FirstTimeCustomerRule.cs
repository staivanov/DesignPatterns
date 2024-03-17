namespace RulesEngine.RulesCollection
{
    public class FirstTimeCustomerRule : IDiscountRule
    {
        public decimal CalculateDiscount(Customer customer, decimal? discount)
             => !customer.DateOfFirstPurchase.HasValue ? .15m : 0;
    }
}
