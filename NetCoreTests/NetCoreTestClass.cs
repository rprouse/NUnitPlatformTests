using System;
using NUnit.Framework;

namespace NetCoreTests
{
    [TestFixture]
    public class NUnitNetCoreClass
    {
        [Test]
        public void APassingTest()
        {
            Assert.Pass("This works!");
        }
    }
}
