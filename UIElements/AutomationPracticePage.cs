using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject2
{
    public class AutomationPracticePage
    {
        public AutomationPracticePage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How =How.Id,Using ="s")]
        public IWebElement SearchBar { get; set; }

        [FindsBy(How =How.Id,Using ="searchsubmit")]
        public IWebElement SubmitButton { get; set; }
    }
}
