using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopmentByExample
{
    public class Money : IExpression
    {
        protected internal int amount;
        protected internal string currency;
        public Money Times(int multiplier)
        {
            return new Money(amount * multiplier, currency);
        }

        public Money(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public override Boolean Equals(Object obj)
        {
            Money money = (Money)obj;
            return amount == money.amount && Currency().Equals(money.Currency());
        }

        public override int GetHashCode()
        {
            return this.amount;
        }

        public static Money Dollar(int amount)
        {
            return new Money(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Money(amount, "CHF");
        }

        public string Currency()
        {
            return this.currency;
        }

        public IExpression Plus(Money addend)
        {
            return new Sum(this, addend);
        }

        public Money Reduce(Bank bank, String to)
        {
            int rate = bank.Rate(currency, to);
            return new Money(amount / rate, to);
        }

        public override string ToString()
        {
            return amount.ToString() + " " + currency;
        }
    }
}
