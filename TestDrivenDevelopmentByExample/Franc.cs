using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopmentByExample
{
    public class Franc
    {
        private int amount;
        public Franc(int amount)
        {
            this.amount = amount;
        }

        public Franc()
        {
        }

        public Franc times(int multiplier)
        {
            return new Franc(amount * multiplier);
        }

        public override bool Equals(Object obj)
        {
            Franc franc = (Franc)obj;
            return amount == franc.amount;
        }

        public override int GetHashCode()
        {
            return this.amount;
        }
    }
}
