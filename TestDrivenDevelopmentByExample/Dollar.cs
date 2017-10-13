using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopmentByExample
{
    public class Dollar
    {
        public int amount;
        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public Dollar()
        {
        }

        public Dollar times(int multiplier)
        {
            return new Dollar(amount * multiplier);
        }

        public override bool Equals(Object obj)
        {
            Dollar dollar = (Dollar)obj;
            return amount == dollar.amount;
        }

        public override int GetHashCode()
        {
            return this.amount;
        }
    }
}
