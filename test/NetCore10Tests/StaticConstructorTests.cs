using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace NetCore10Tests
{
    [TestFixture]
    public class StaticConstructorTests
    {
        static class ClassWithStaticConstructor
        {
            static ClassWithStaticConstructor()
            {
                throw new Exception("Crash!");
            }

            public static int Add(int x, int y) => x + y;
        }

        [Test]
        public void UseClassWithStaticConstructor()
        {
            Assert.That(ClassWithStaticConstructor.Add(2, 2), Is.EqualTo(4));
        }
    }
}
