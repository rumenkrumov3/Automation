using OpenQA.Selenium;
using SeleniumAdvance.Pages.RandomPagesTests.GoogleSearch;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumAdvance.Pages.DemoQA.SortableTests.Objects
{
    public partial class Sortable : BasePage
    {
        public Sortable(IWebDriver driver)
            : base(driver)
        {

        }

        public IWebElement sourceBox => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/div/div[1]/div/div[1]"));
        public IWebElement targetBox => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/div/div[1]/div/div[4]"));
        public IWebElement boxAfterTarget => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/div/div[1]/div/div[5]"));
        public IWebElement sourceBoxAfterElement => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/div/div[1]/div/div[4]"));
        public IWebElement boxBeforeTargetBox => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/div/div[1]/div/div[3]"));
        public IWebElement targetBoxAfterElement => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/div/div[1]/div/div[3]"));
    }
}
