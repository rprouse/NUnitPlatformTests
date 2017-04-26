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
    }
}
