using OpenQA.Selenium;
using SeleniumAdvance.Pages.RandomPagesTests.GoogleSearch;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumAdvance.Pages.DemoQA.SelectableTests.Objects
{
    public partial class Selectable : BasePage
    {
        public Selectable(IWebDriver driver)
            : base(driver)
        {

        }

        public IWebElement firstButton => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/div/div[1]/ul/li[1]"));

        public IWebElement secondButton => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/div/div[1]/ul/li[2]"));
    }
}
