﻿namespace WyCash
{
    internal class Franc : Money
    {
        public Franc(int amount) : base(amount)
        {
        }

        public override Money Times(int multiplier)
        {
            return new Franc(Amount * multiplier);
        }
    }
}