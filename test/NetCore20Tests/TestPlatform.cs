using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace NetCore20Tests
{
    [TestFixture]
    public class TestPlatform
    {
        [Test]
        public void IsRunning64Bit()
        {
            unsafe
            {
                Assert.That(sizeof(IntPtr), Is.EqualTo(8));
            }
        }
    }
}
