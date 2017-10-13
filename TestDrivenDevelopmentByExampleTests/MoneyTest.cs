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
            Assert.AreEqual(10, product.amount);
            product = five.times(3);
            Assert.AreEqual(15, product.amount);
        }

        [TestMethod()]
        public void testEquality()
        {
            Assert.IsTrue(new Dollar(5).equals(new Dollar(5)));
            Assert.IsFalse(new Dollar(5).equals(new Dollar(6)));
        }
    }
}