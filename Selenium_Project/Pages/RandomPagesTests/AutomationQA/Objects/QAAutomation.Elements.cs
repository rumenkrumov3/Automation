using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumAdvance.Pages.RandomPagesTests.GoogleSearch;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumAdvance.Pages.RandomPagesTests.AutomationQA.Objects
{
    public partial class QAAutomation : BasePage
    {
        public QAAutomation(IWebDriver driver)
            : base(driver)
        {

        }

        public IWebElement coursesField => Driver.FindElement(By.CssSelector("#header-nav > div.toggle-nav.toggle-holder > ul > li:nth-child(2) > a > span"));
        
        public IWebElement QAAutomationCourse => Driver.FindElement(By.CssSelector("#header-nav > div.toggle-nav.toggle-holder > ul > li.nav-item.dropdown-item.open > div > div > div.row.no-margin-offset.courses-and-modules-wrapper > div.col-md-8.open-courses-wrapper.open-courses-background > div > div:nth-child(2) > ul > div:nth-child(1) > ul > li > a"));
        
        public IWebElement headingText => Driver.FindElement(By.XPath("//h1[contains(text(), 'QA Automation - май 2020')]"));
    }
}
