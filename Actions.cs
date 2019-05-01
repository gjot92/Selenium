using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject2
{
    public static class Actions
    {
        public static void FillInSearchBarHomePage()
        {
            HomePage homePage = new HomePage();

            homePage.SearchBar.SendKeys("Complicated Page");
            homePage.SearchBar.Click();
        }

        public static void FillInSearchBarAutomationPracticePage()
        {
            AutomationPracticePage automationPracticePage = new AutomationPracticePage();
            

            automationPracticePage.SearchBar.SendKeys("Complicated Page");
            automationPracticePage.SubmitButton.Click();
            IWebElement ComplicatedPage = Driver.driver.FindElement(By.CssSelector("#post-579 > h2 > a"));
            ComplicatedPage.Click();
            
           
        }

        public static void MaximizeScreen()
        {
            Driver.driver.Manage().Window.Maximize();
        }

        public static void FillInLoginPage()
        {
            LoginPage loginPage = new LoginPage();

            loginPage.EmailTextBox.SendKeys(Config.Credentials.validEmail);
            loginPage.PasswordTextBox.SendKeys(Config.Credentials.validPassword);
            loginPage.SignInButton.Click();

           
        }
    }
}
