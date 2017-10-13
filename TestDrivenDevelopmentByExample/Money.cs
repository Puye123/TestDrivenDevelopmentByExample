using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopmentByExample
{
    public class Money
    {
        protected internal int amount;
        public override Boolean Equals(Object obj)
        {
            Money money = (Money)obj;
            return amount == money.amount;
        }

        public override int GetHashCode()
        {
            return this.amount;
        }
    }
}
