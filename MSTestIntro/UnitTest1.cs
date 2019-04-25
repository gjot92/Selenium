using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestIntro
{
    [TestClass]
    [TestCategory("LoginFeature")]
    public class UnitTest1
    {
        private int a; // know this variable is available for the entire class(higher scope)
        public TestContext Test3Context { get; set; }
        private static TestContext _testContext;

        [ClassInitialize] //Runs one time before any of the tests are executed

        public static void RunBeforeAnyOfTheTests(TestContext testContext)
        {
             _testContext = testContext; // this makes testContext available to all test methods
            Trace.Write("Will run once before any of the tests in the class");

        }
        [TestInitialize]

        public void RunBeforeEveryTest()
        {
            a = 1;
        }


        [TestMethod]
        [Description("Demo Unit tests")]
        public void TestMethod1()
        {

            var b = 2;

            Assert.AreEqual(3, a + b);
            Trace.Write(_testContext.CurrentTestOutcome);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Trace.Write(_testContext.TestName);
            Assert.IsTrue(a == 1);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))] // if you expect an exception to be thrown use this attribute with typeof keyword
        public void TestMethod3()
        {

            Assert.AreNotEqual(1, a);
        }

        [TestCleanup] // what to do after every test method

        public void RunAfterEveryTestMethod()
        {
            Trace.Write("This message comes after every test method");
        }

      

        [ClassCleanup]// Runs once after all the tests in the class have been run
        public static void RunAfterAllOfTheTests()
        {
            Trace.Write("I run after all the tests in the class");
        }
    }
}