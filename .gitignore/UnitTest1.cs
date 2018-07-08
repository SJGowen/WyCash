using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WyCash
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDollarMultiplication()
        {
            var five = new Dollar(5);
            Assert.IsTrue(Equals(new Dollar(10), five.Times(2)));
            Assert.IsTrue(Equals(new Dollar(15), five.Times(3)));
        }

        [TestMethod]
        public void TestFrancMultiplication()
        {
            var five = new Franc(5);
            Assert.IsTrue(Equals(new Franc(10), five.Times(2)));
            Assert.IsTrue(Equals(new Franc(15), five.Times(3)));
        }

        [TestMethod]
        public void TestEquality()
        {
            Assert.IsTrue(Equals(new Dollar(5), new Dollar(5)));
            Assert.IsFalse(Equals(new Dollar(5), new Dollar(6)));
            Assert.IsTrue(Equals(new Franc(5), new Franc(5)));
            Assert.IsFalse(Equals(new Franc(5), new Franc(6)));
            Assert.IsFalse(Equals(new Franc(5), new Dollar(5)));
        }
    }
}
