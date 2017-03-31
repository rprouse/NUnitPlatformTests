using System;
using Xunit;

namespace XUnitTestProject
{
    public class UnitTest
    {
        [Fact]
        public void XUnitPassingTest()
        {
            Assert.Equal(1, 1);
        }
    }
}
