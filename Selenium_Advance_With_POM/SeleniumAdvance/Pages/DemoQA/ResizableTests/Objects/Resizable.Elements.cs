using OpenQA.Selenium;
using SeleniumAdvance.Pages.RandomPagesTests.GoogleSearch;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumAdvance.Pages.DemoQA.ResizableTests.Objects
{
    public partial class Resizable : BasePage
    {
        public Resizable(IWebDriver driver)
            : base(driver)
        {

        }

        public IWebElement resizableArrow => Driver.FindElement(By.CssSelector("#resizableBoxWithRestriction > span"));

        public IWebElement resizableWindow => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/div[1]/div"));
    }
}
