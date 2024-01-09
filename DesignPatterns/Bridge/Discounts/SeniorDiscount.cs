namespace Bridge.Discounts
{
    public class SeniorDiscount : Discount
    {
        public override int GetDiscount()
        {
            return 20;
        }
    }
}
