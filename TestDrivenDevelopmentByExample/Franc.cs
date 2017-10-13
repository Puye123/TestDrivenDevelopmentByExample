using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopmentByExample
{
    public class Franc : Money
    {
        public Franc(int amount)
        {
            this.amount = amount;
        }

        public Franc()
        {
        }

        public override Money times(int multiplier)
        {
            return new Franc(amount * multiplier);
        } 
    }
}
