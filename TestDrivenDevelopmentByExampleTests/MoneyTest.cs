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
            Money five = Money.Dollar(5);
            Assert.AreEqual(Money.Dollar(10), five.Times(2));
            Assert.AreEqual(Money.Dollar(15), five.Times(3));
        }

        [TestMethod()]
        public void testEquality()
        {
            Assert.IsTrue(Money.Dollar(5).Equals(Money.Dollar(5)));
            Assert.IsFalse(Money.Dollar(5).Equals(Money.Dollar(6)));
            Assert.IsTrue(Money.Franc(5).Equals(Money.Franc(5)));
            Assert.IsFalse(Money.Franc(5).Equals(Money.Franc(6)));
            Assert.IsFalse(Money.Franc(5).Equals(Money.Dollar(5)));
        }

        [TestMethod()]
        public void testFrancMultiplication()
        {
            Money five = Money.Franc(5);
            Assert.AreEqual(Money.Franc(10), five.Times(2));
            Assert.AreEqual(Money.Franc(15), five.Times(3));
        }

        [TestMethod()]
        public void testCurrency()
        {
            Assert.AreEqual("USD", Money.Dollar(1).Currency());
            Assert.AreEqual("CHF", Money.Franc(1).Currency());
        }
    }
}