namespace Bridge.Discounts
{
    public abstract class NoDiscount : Discount
    {
        public override int GetDiscount() => 0;
    }
}
