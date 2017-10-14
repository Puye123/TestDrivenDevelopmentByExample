using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopmentByExample
{
    public abstract class Money
    {
        protected internal int amount;
        protected internal string currency;
        public abstract Money Times(int multiplier);

        public Money(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public override Boolean Equals(Object obj)
        {
            Money money = (Money)obj;
            return amount == money.amount && GetType().Equals(money.GetType());
        }

        public override int GetHashCode()
        {
            return this.amount;
        }

        public static Money Dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Franc(amount, "CHF");
        }

        public string Currency()
        {
            return this.currency;
        }
    }
}
