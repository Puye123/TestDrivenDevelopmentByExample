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
            Money five = Money.dollar(5);
            Assert.AreEqual(Money.dollar(10), five.times(2));
            Assert.AreEqual(Money.dollar(15), five.times(3));
        }

        [TestMethod()]
        public void testEquality()
        {
            Assert.IsTrue(Money.dollar(5).Equals(Money.dollar(5)));
            Assert.IsFalse(Money.dollar(5).Equals(Money.dollar(6)));
            Assert.IsTrue(Money.franc(5).Equals(Money.franc(5)));
            Assert.IsFalse(Money.franc(5).Equals(Money.franc(6)));
            Assert.IsFalse(Money.franc(5).Equals(Money.dollar(5)));
        }

        [TestMethod()]
        public void testFrancMultiplication()
        {
            Money five = Money.franc(5);
            Assert.AreEqual(Money.franc(10), five.times(2));
            Assert.AreEqual(Money.franc(15), five.times(3));
        }
    }
}