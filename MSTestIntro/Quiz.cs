using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestIntro
{
    [TestClass]
    [TestCategory("Quiz")]
    public class Quiz
    {
        [TestMethod]
        public void BasicAddition()
        {
            int a = 1;
            int b = 1;

            Assert.AreEqual(2, a + b);
        }

        [TestMethod]
        public void AutomaticFailingTest()
        {
            Assert.Fail("This test should always fail");
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void WrongAdditionTest()
        {
            int a = 10;
            int b = 10;

            Assert.AreEqual(21, a + b);

        }
    }
}
