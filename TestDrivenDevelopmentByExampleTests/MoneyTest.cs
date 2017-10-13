using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDrivenDevelopmentByExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopmentByExample.Tests
{
    [TestClass()]
    public class MoneyTest
    {
        [TestMethod()]
        public void testMultiplication()
        {
            Dollar five = new Dollar(5);
            Dollar product = five.times(2);
            Assert.AreEqual(new Dollar(10), product);
            product = five.times(3);
            Assert.AreEqual(15, product.amount);
        }

        [TestMethod()]
        public void testEquality()
        {
            Assert.IsTrue(new Dollar(5).Equals(new Dollar(5)));
            Assert.IsFalse(new Dollar(5).Equals(new Dollar(6)));
        }
    }
}