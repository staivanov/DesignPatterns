namespace Bridge.Discounts
{
    public class NoDiscount : Discount
    {
        public override int GetDiscount() => 0;
    }
}
