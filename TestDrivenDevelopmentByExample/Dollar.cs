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

        public void times(int multiplier)
        {
            amount *= multiplier;
        }
    }
}
