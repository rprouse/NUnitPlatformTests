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

        [Test]
        public void FailingTest()
        {
            Assert.Fail("This is intended to fail");
        }

        [Test]
        public void AssertIgnoreTest()
        {
            Assert.Ignore("Ignoring with an assert");
        }

        [Test]
        [Ignore("Ignoring with an attribute")]
        public void AttributeIgnoreTest()
        {
            Assert.Fail("This should be ignored");
        }

        [Test]
        public void FailsAssumptionTest()
        {
            Assume.That(false, "Failed an assumption");
        }
    }
}
