namespace Bridge.Discounts
{
    public class InvalidDiscount : Discount
    {
        public override int GetDiscount() => 15;
    }
}
