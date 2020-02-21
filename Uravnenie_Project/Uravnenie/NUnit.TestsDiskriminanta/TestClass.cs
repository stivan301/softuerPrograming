// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using Uravnenie;
using System;
namespace NUnit.TestsDiskriminanta
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestMethod()
        {
            // TODO: Add your test code here
            var answer = 42;
            Assert.That(answer, Is.EqualTo(42), "Some useful error message");
        }
        [Test]
        public void TestDiskriminantaUravnenie()
        {
            Diskriminanta d = new Diskriminanta();
            var ex = Assert.Throws<InvalidOperationException>(() => d.D(1, 1, 1));
            Assert.That(ex.Message, Is.EqualTo("Уравнението няма реални корени"));

        }
    }
}
