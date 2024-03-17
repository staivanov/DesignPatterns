namespace RulesEngine.RulesCollection
{
    public class LoyalDiscountCustomerRule : IDiscountRule
    {
        public decimal CalculateDiscount(Customer customer, decimal? currentDiscount)
        {
            bool isBirthday = customer.DateOfBirth.HasValue && customer.DateOfBirth.Value.Day == DateTime.Today.Day
                               && (customer.DateOfBirth.Value.Month == DateTime.Today.Month);

            if (customer.DateOfFirstPurchase.HasValue)
            {
                if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-15))
                {
                    return isBirthday ? .25m : .15m;
                }
                if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-10))
                {
                    return isBirthday ? .22m : .12m;
                }
                if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-5)
                    || isBirthday)
                {
                    return isBirthday ? .20m : .10m;
                }
                if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-2)
                    && !customer.IsVeteran)
                {
                    return isBirthday ? .18m : .08m;
                }
                if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-1)
                    && !customer.IsVeteran)
                {
                    return isBirthday ? .15m : .05m;
                }
            }

            return 0;
        }
    }
}
