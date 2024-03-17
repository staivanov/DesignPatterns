namespace RulesEngine.RulesCollection
{
    public class BirthdayDiscountRule : IDiscountRule
    {
        public decimal CalculateDiscount(Customer customer, decimal? currentDiscount)
        {
            bool isBirthday = customer.DateOfBirth.HasValue && customer.DateOfBirth.Value.Day == DateTime.Today.Day
                      && (customer.DateOfBirth.Value.Month == DateTime.Today.Month);

            return (decimal)(isBirthday ? currentDiscount + 0.1m : currentDiscount);
        }
    }
}
