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
        public IExpression augend;
        // 加数
        public IExpression addend;

        public Sum(IExpression augend, IExpression addend)
        {
            this.augend = augend;
            this.addend = addend;
        }

        public IExpression Plus(IExpression addend)
        {
            return new Sum(this, addend);
        }

        public IExpression Times(int multiplier)
        {
            return new Sum(augend.Times(multiplier), addend.Times(multiplier));
        }

        public Money Reduce(Bank bank, string to)
        {
            int amount = augend.Reduce(bank, to).amount + addend.Reduce(bank, to).amount;
            return new Money(amount, to);
        }
    }
}
