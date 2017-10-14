using System;

namespace TestDrivenDevelopmentByExample
{
    public interface IExpression
    {
        Money Reduce(Bank bank, String to);
        IExpression Plus(IExpression addend);
        IExpression Times(int mutiplier);
    }
}
