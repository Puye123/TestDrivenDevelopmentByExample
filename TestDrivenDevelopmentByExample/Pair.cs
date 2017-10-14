using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopmentByExample
{
    public class Pair
    {
        private string from;
        private string to;

        public Pair(string from, string to)
        {
            this.from = from;
            this.to = to;
        }

        public override bool Equals(object obj)
        {
            Pair pair = (Pair)obj;
            return from == pair.from && to == pair.to;
        }

        public override int GetHashCode()
        {
            return 0;
        }
    }
}
