using System.Collections;
using NetStandard13Library;
using NUnit.Framework;

namespace NetCore10Tests
{
    [TestFixture]
    public class TestAddition
    {
        Addition _add;

        [SetUp]
        public void SetUp()
        {
            _add = new Addition();
        }

        [TestCaseSource(nameof(AdditionData))]
        public void CanAddTwoNumbers(int x, int y, int expected)
        {
            var result = _add.Add(x, y);
            Assert.That(result, Is.EqualTo(expected));
        }

        public static IEnumerable AdditionData()
        {
            yield return new TestCaseData(1, 1, 2);
            yield return new TestCaseData(1, 10, 11);
            yield return new TestCaseData(42, 42, 84);
            yield return new TestCaseData(100, 12, 112);
            yield return new TestCaseData(-1, -1, -2);
            yield return new TestCaseData(1, -1, 0);
            yield return new TestCaseData(-100, 1, -99);
            yield return new TestCaseData(6, 4, 10);
            yield return new TestCaseData(10, -15, -5);
        }

        [TestCase(int.MaxValue, 1)]
        [TestCase(int.MinValue, 1)]
        [TestCase(1, int.MaxValue)]
        [TestCase(1, int.MinValue)]
        public void ThrowsArgumentException(int x, int y)
        {
            Assert.That(() => _add.Add(x, y), Throws.ArgumentException);
        }


    }
}
