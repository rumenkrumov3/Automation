using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumAdvance.Pages.RandomPagesTests.GoogleSearch;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumAdvance.Pages.RandomPagesTests.AutomationQA.Objects
{
    public partial class QAAutomation : BasePage
    {
        public void AssertHeadingText(IWebDriver driver)
        {
            string actualText = headingText.Text;
            string expectedText = "QA Automation - май 2020";
            Assert.AreEqual(expectedText, actualText, string.Format("Strings are not equal"));
        }
    }
}
