namespace WyCash
{
    internal class Dollar : Money
    {
        public Dollar(int amount) : base(amount)
        {
        }

        public override Money Times(int multiplier)
        {
            return new Dollar(Amount * multiplier);
        }
    }
}