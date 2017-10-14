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
            Assert.IsFalse(Money.Franc(5).Equals(Money.Dollar(5)));
        }

        [TestMethod()]
        public void testCurrency()
        {
            Assert.AreEqual("USD", Money.Dollar(1).Currency());
            Assert.AreEqual("CHF", Money.Franc(1).Currency());
        }

        [TestMethod()]
        public void testSimpleAddition()
        {
            Money five = Money.Dollar(5);

            IExpression sum = five.Plus(five);
            Bank bank = new Bank();
            Money reduced = bank.Reduce(sum, "USD");
            Assert.AreEqual(Money.Dollar(10), reduced);
        }

        [TestMethod()]
        public void testPlusReturnsSum()
        {
            Money five = Money.Dollar(5);
            IExpression result = five.Plus(five);
            Sum sum = (Sum)result;
            Assert.AreEqual(five, sum.augend);
            Assert.AreEqual(five, sum.addend);
        }

        [TestMethod()]
        public void testReduceSum()
        {
            IExpression sum = new Sum(Money.Dollar(3), Money.Dollar(4));
            Bank bank = new Bank();
            Money result = bank.Reduce(sum, "USD");
            Assert.AreEqual(Money.Dollar(7), result);
        }

        [TestMethod()]
        public void testReduceMoney()
        {
            Bank bank = new Bank();
            Money result = bank.Reduce(Money.Dollar(1), "USD");
            Assert.AreEqual(Money.Dollar(1), result);
        }
    }
}