using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopmentByExample
{
    public class Dollar : Money
    {
        public Dollar(int amount, string currency) : base(amount, currency) 
        {
        }
    }
}
