using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void GoToWebsite()
        {
            NavigateTo.NavigateToWebsite();
            Actions.MaximizeScreen();
        }
        [TestMethod]
        public void OnComplicatedPage()
        {
            //Arrange-all necessary preconditions and inputs.
            ;
            NavigateTo.NavigateToAutomationExercisePage();
            
            Actions.FillInSearchBarAutomationPracticePage();
           
            IWebElement TextOnPage = Driver.driver.FindElement(By.CssSelector("#et-boc > div > div > div.et_pb_row.et_pb_row_0 > div > div > div > h2"));  

            //Act-on the object or method under test.
            
            //Assert-that the expected results have occurred.
            StringAssert.Equals("Skills Improved:", TextOnPage);
        }

        [TestCleanup]

        public void ShutDown()
        {
            Driver.driver.Quit();
        }
    }
}
