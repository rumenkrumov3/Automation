using DemoQA.Tests;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System.IO;

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
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string dirPath = Path.GetFullPath(@"..\..\..\", Directory.GetCurrentDirectory());
                var screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                screenshot.SaveAsFile($"{dirPath}\\Screenshots\\{TestContext.CurrentContext.Test.FullName}.png", ScreenshotImageFormat.Png);
            }
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
