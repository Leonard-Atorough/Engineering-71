using NUnit.Framework;
using Lab04_Methods;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Lab04_Methods_TESTS
{
    public class Tests
    {
        private int _result;
        private int _sum;
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(10, 2, 4, 80)]
        [TestCase(0, -3, 7, 0)]
        [Test]
        public void ProductIsCorrect(int a, int b, int c, int expected)
        {
            var actual = Lab04_Methods.Program.TripleCalc(a, b, c, out int sum);
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 2, 4, 16)]
        [TestCase(0, -3, 7, 4)]
        public void SumIsCorrect(int a, int b, int c, int expected)
        {
            var actual = Lab04_Methods.Program.TripleCalc(a, b, c, out int sum);
            // assert
            Assert.AreEqual(expected, sum);
        }
    }
}