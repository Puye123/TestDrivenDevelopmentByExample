using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopmentByExample
{
    public interface IExpression
    {
        Money Reduce(String to);
    }
}
