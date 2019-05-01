using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject2
{
    public class LoginPage
    {
        public LoginPage()
        {
            PageFactory.InitElements(Driver.driver, this);
           
        }
        [FindsBy(How = How.CssSelector, Using = "#user_email")]
        public IWebElement EmailTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "user_password")]
        public IWebElement PasswordTextBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#notifications-error > ul > li")]
        public IWebElement LoginErrorAlert { get; set; }


        [FindsBy(How = How.Id, Using = "btn-signin")]
        public IWebElement SignInButton { get; set; }
    }
}
