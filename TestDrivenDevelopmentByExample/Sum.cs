using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopmentByExample
{
    public class Sum : IExpression
    {
        // 被加算数
        public Money augend;
        // 加数
        public Money addend;

        public Sum(Money augend, Money addend)
        {
            this.augend = augend;
            this.addend = addend;
        }

        public Money Reduce(string to)
        {
            int amount = augend.amount + addend.amount;
            return new Money(amount, to);
        }
    }
}
