using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MathUtils;

namespace MathUtilsMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            var mo = new MathOperations();
            Assert.AreEqual(10, mo.Add(5, 5));
        }
        [TestMethod]
        public void TestSubtract()
        {
            var mo = new MathOperations();
            Assert.AreEqual(5, mo.Subtract(10, 5));
        }
        [TestMethod]
        public void ForceFail()
        {
            var mo = new MathOperations();
            Assert.AreEqual(5, mo.Subtract(11, 5));
        }
    }
}
