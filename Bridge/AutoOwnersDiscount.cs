namespace Bridge
{
    // ConcreteImplementorC
    public class AutoOwnersDiscount : Discount
    {
        public override int GetDiscount()
        {
            return 5;
        }
    }
}
