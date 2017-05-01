using System;
using NUnit.Framework;

namespace NetCore10Tests
{
    [TestFixture]
    public class MoreNetCoreTests
    {
        [Test]
        public void MoreDotNetCoreTests()
        {
            Assert.Pass("Passes");
        }

        [Category("Whatever")]
        [Test]
        public void OneMoreDotNetCoreTests()
        {
            Assert.Pass("Passes");
        }
    }
}
