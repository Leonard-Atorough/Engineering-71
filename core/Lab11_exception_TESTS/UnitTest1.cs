using NUnit.Framework;
using System;
using Lab11_Exceptions;

namespace Lab11_exception_TESTS
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(-1)]
        [TestCase(4)]
        public void Test1(int pos)
        {
            var ex = Assert.Throws<ArgumentException>(() => Program.ChangeBeatles(pos, "George"));

            Assert.AreEqual("Another beatle cannot be added", ex.Message, "The messages are not the same");
        }
    }
}