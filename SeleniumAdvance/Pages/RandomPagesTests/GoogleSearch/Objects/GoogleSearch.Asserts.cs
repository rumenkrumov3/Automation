using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumAdvance.Pages.RandomPagesTests.GoogleSearch
{
    public partial class GoogleSearch : BasePage
    {
        public void AssertTitles(IWebDriver driver)
        {
            string actualTitle = Driver.Title;
            string expectedTitle = "SeleniumHQ Browser Automation";

            Assert.AreEqual(actualTitle, expectedTitle);
        }
    }
}
