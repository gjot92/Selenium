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

        [FindsBy(How =How.CssSelector,Using = "#et-boc > div > div.et_pb_section.et_pb_section_1.et_section_specialty > div > div.et_pb_column.et_pb_column_3_4.et_pb_column_0.et_pb_specialty_column.et_pb_css_mix_blend_mode_passthrough > div > div > div > div > ul > li:nth-child(6) > a")]
        public IWebElement LoginPageLink { get; set; }

    }
}
