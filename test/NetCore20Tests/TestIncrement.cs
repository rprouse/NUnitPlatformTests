using System;
using NetStandard20Library;
using NUnit.Framework;

namespace NetCore20Tests
{
    [TestFixture]
    public class TestIncrement
    {
        [Test]
        public void IncrementAddsOne()
        {
            Assert.That(1.AddOne(), Is.EqualTo(2));
        }
    }
}
