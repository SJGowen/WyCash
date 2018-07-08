using System;
using System.CodeDom;
using System.Reflection;

namespace WyCash
{
    internal abstract class Money
    {
        protected int Amount;

        protected Money(int amount)
        {
            Amount = amount;
        }

        public abstract Money Times(int multiplier);

        public override bool Equals(object obj)
        {
            var money = (Money)obj;
            return money != null && this.Amount == money.Amount
                && this.GetType().Name == money.GetType().Name;
        }

        public override int GetHashCode()
        {
            return -602769199 + Amount.GetHashCode();
        }
    }
}