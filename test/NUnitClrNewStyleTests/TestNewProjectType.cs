using System;
using NUnit.Framework;

namespace NUnitClrNewStyleTests
{
    [TestFixture]
    public class TestNewProjectType
    {
        [Test]
        public void NewStyleUnitTests()
        {
            Assert.Pass("This works too!");
        }

        [Category("Whatever")]
        [Test]
        public void NewStyleUnitTests2()
        {
            Assert.Pass("This works too!");
        }
    }
}
