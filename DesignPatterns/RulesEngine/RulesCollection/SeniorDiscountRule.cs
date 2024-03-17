namespace RulesEngine.RulesCollection
{
    public class SeniorDiscountRule : IDiscountRule
    {
        public decimal CalculateDiscount(Customer customer, decimal? currentDiscount)
        {
            bool isBirthday = customer.DateOfBirth.HasValue && customer.DateOfBirth.Value.Day == DateTime.Today.Day
                 && (customer.DateOfBirth.Value.Month == DateTime.Today.Month);

            if (customer.DateOfBirth < DateTime.Now.AddYears(-65))
            {
                return isBirthday ? .15m : 0.05m;
            }

            return 0;
        }
    }
}
