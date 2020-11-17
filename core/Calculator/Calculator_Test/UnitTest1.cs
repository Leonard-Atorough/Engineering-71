using NUnit.Framework;
using Calculator;

namespace Calculator_Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(10.2, 2, 12.2)]
        [TestCase(0, 0, 0)]
        [TestCase(100, -100, 0)]
        public void AddTest(double a, double b, double expected)
        {
            var result = CalculatorMethods.Add(a, b);
            Assert.AreEqual(expected, result);
        }

        [TestCase(10, 2, 8)]
        [TestCase(0, 0, 0)]
        [TestCase(100, -100, 200)]
        public void SubtractTest(double a, double b, double expected)
        {
            var result = CalculatorMethods.Subtract(a, b);
            Assert.AreEqual(expected, result);
        }

        [TestCase(10, 2, 20)]
        [TestCase(0, 0, 0)]
        [TestCase(100, -100, -10000)]
        public void ProductTest(double a, double b, double expected)
        {
            var result = CalculatorMethods.Product(a, b);
            Assert.AreEqual(expected, result);
        }

        [TestCase(10, 2, 5)]
        [TestCase(0, 10, 0)]
        [TestCase(100, -100, -1)]
        public void QuotientTest(double a, double b, double expected)
        {
            var result = CalculatorMethods.Quotient(a, b);
            Assert.AreEqual(expected, result);
        }

        [TestCase(9, 2, 1)]
        [TestCase(71, 3, 2)]
        [TestCase(100, -100, 0)]
        public void ModulusTest(double a, double b, double expected)
        {
            var result = CalculatorMethods.Modulus(a, b);
            Assert.AreEqual(expected, result);
        }

        [Test]

        public void divideByZeroExceptionTest()
        {

        }

    }
}