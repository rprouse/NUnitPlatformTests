using System;
using NUnit.Framework;

namespace NetStandardTests
{
    [TestFixture]
    public class NetStandardClass
    {
        [Test]
        public void APassingTest()
        {
            Assert.Pass("This works!");
        }
    }
}
