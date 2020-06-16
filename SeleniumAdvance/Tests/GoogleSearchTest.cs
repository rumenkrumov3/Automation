using DemoQA.Tests;
using NUnit.Framework;

namespace SeleniumAdvance.Pages.RandomPagesTests.GoogleSearch
{

    [TextFixture]
    public class GoogleSearchTest : BaseTest
    {
        private GoogleSearch _page;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://www.google.com");           
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

        [Test]
        public void GoogleSearch()
        {
            #region StartOfTest 

            _page = new GoogleSearch(Driver);

            _page.searchTextField.SendKeys("selenium");
            _page.firstAvailableChoice.Submit();
            _page.firstChoiceOfSearchedPage.Click();

            _page.AssertTitles(Driver);
          
            #endregion EndOfTest
        }

    }
}
