using NUnit.Framework;
using Lab05_Selection;

namespace Lab05_Selection_Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        /* [Test]
        public void Mark40AndOverPasses()
        {
            var result = Program.PassFail(40);
            Assert.AreEqual("Pass", result);
        }

        [Test]
        public void Mark39AndBelowFails()
        {
            var result = Program.PassFail(39);
            Assert.AreEqual("Fail", result);
        } */

        /* [TestCase(75, "Pass with distinction")]
        [TestCase(88, "Pass with distinction")]
        [TestCase(100, "Pass with distinction")]
        public void Mark75AndOverPassesWithDistinction(int mark, string expected)
        {
            var result = Program.Grade(mark);
            Assert.AreEqual(expected, result);
        }

        [TestCase(74, "Pass with merit")]
        [TestCase(60, "Pass with merit")]
        public void Markbetween60And74PassesWithMerit(int mark, string expected)
        {
            var result = Program.Grade(mark);
            Assert.AreEqual(expected, result);
        } */

        [TestCase(5,"Error")]
        [TestCase(3, "Code Red")]
        [TestCase(2, "Code Amber")]
        [TestCase(1, "Code Amber")]
        [TestCase(0, "Code Green")]
        public void PriorityTest (int level, string expected)
        {
            Assert.AreEqual(expected, Program.Priority(level));
        }
    }
}