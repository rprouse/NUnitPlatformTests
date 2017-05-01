using System;
using NUnit.Framework;

namespace NetCore11Tests
{
    [TestFixture]
    public class NUnitNetCoreClass
    {
        [Test]
        public void APassingTest()
        {
            Assert.Pass("This works!");
        }

        [Category("Whatever")]
        [Test]
        public void OneMorePassingTest()
        {
            Assert.Pass("This works!");
        }

        [TestCase(1, 2, 3)]
        [TestCase(3, 2, 5)]
        public void TestAddition(int x, int y, int expected)
        {
            Assert.That(x + y, Is.EqualTo(expected));
        }
    }
}
