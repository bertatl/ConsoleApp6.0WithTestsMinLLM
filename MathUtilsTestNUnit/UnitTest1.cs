using NUnit.Framework;
using MathUtils;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using NUnit.Framework.Legacy;

namespace MathUtilsTestNUnit
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAdd()
        {
            var mo = new MathOperations();
            ClassicAssert.AreEqual(3, mo.Add(1, 2));
        }

        [Test]
        public void TestSubtract()
        {
            var mo = new MathOperations();
            ClassicAssert.AreEqual(2, mo.Subtract(4, 2));
        }

        [Test]
        public void TestMultiply()
        {
            var mo = new MathOperations();
            ClassicAssert.AreEqual(8, mo.Multiply(4, 2));
        }

        [Test]
        public void ForceFail()
        {
            var mo = new MathOperations();
            ClassicAssert.AreEqual(2, mo.Subtract(6, 2));
        }
    }
}