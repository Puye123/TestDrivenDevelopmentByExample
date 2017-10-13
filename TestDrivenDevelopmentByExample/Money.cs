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
        public abstract Money times(int multiplier);
        public override Boolean Equals(Object obj)
        {
            Money money = (Money)obj;
            return amount == money.amount && GetType().Equals(money.GetType());
        }

        public override int GetHashCode()
        {
            return this.amount;
        }

        public static Money dollar(int amount)
        {
            return new Dollar(amount);
        }

        public static Franc franc(int amount)
        {
            return new Franc(amount);
        }
    }
}
