using NUnit.Framework;

namespace MultiTargetTests
{
    [TestFixture]
    public class MultiTargetTests
    {
        [Test]
        public void TestOnMultiplePlatforms()
        {
#if NETCOREAPP1_1
            Assert.Pass(".NET Core");
#else
            Assert.Pass(".NET Desktop");
#endif
        }
    }
}
