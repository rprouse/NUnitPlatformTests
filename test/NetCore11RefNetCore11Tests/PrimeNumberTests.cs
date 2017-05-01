using System.Linq;
using NetCoreApp11;
using NUnit.Framework;

namespace NetCore11RefNetCore11Tests
{
    [TestFixture]
    public class PrimeNumberTests
    {
        [Test]
        public void FindsCorrectNumberOfPrimes([Range(0, 5)]int count)
        {
            var primes = count.Primes();
            Assert.That(primes.Count(), Is.EqualTo(count));
        }

        [Category("Whatever")]
        [Test]
        public void ThrowsArgumentExceptionWhenLessThanZero()
        {
            Assert.That(() => (-1).Primes().Count(), Throws.ArgumentException);
        }
    }
}
