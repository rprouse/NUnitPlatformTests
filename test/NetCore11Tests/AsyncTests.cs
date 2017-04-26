using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NetStandard16Library;
using NUnit.Framework;

namespace NetCore11Tests
{
    [TestFixture]
    public class AsyncTests
    {
        AsyncMethods _methods;

        [SetUp]
        public void SetUp()
        {
            _methods = new AsyncMethods();
        }

        [Test]
        public async Task IsTrueAsyncReturnsTrue()
        {
            var result = await _methods.IsTrueAsync();
            Assert.That(result, Is.True);
        }

        [TestCase(1, 1, 2)]
        [TestCase(1, 10, 11)]
        [TestCase(42, 42, 84)]
        [TestCase(100, 12, 112)]
        [TestCase(-1, -1, -2)]
        [TestCase(1, -1, 0)]
        [TestCase(-100, 1, -99)]
        [TestCase(6, 4, 10)]
        [TestCase(10, -15, -5)]
        public async Task CanAddAfterDelay(int x, int y, int expected)
        {
            var result = await _methods.AddAfterDelay(x, y);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(int.MaxValue, 1)]
        [TestCase(int.MinValue, 1)]
        [TestCase(1, int.MaxValue)]
        [TestCase(1, int.MinValue)]
        public void ThrowsArgumentException(int x, int y)
        {
            Assert.That(async () => await _methods.AddAfterDelay(x, y), Throws.ArgumentException);
        }

        [TestCase(int.MaxValue, 1)]
        [TestCase(int.MinValue, 1)]
        [TestCase(1, int.MaxValue)]
        [TestCase(1, int.MinValue)]
        public void ThrowsArgumentExceptionClassicStyle(int x, int y)
        {
            Assert.ThrowsAsync<ArgumentException>(async () => await _methods.AddAfterDelay(x, y));
        }
    }
}
