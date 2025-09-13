namespace Bridge
{
    // ConcreteImplementorA
    public class SafeDriverDiscount : Discount
    {
        public override int GetDiscount()
        {
            return 10;
        }
    }
}
