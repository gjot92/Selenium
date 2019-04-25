using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject2
{
    public class HomePage
    {
        public HomePage()
        {
            PageFactory.InitElements(Driver.driver,this); // need to add driver and this keyword
            
        }

        [FindsBy(How = How.CssSelector, Using = "#et_search_icon")] // use this to identify elements on the Homepage(class/webpage)
        public IWebElement SearchBar { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#menu-item-587 > a")]
        public IWebElement AutomationExercisesTab { get; set; }
    }
}
