using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject2
{
    public static class NavigateTo
    {
        public static string url = "https://www.ultimateqa.com";

        public static void NavigateToWebsite()
        {
            Driver.driver.Navigate().GoToUrl(url);
           
        }

        public static void NavigateToAutomationExercisePage()
        {
            HomePage homePage = new HomePage();
    
            homePage.AutomationExercisesTab.Click();

        }
    }
}
