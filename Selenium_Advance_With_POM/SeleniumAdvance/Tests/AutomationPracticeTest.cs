using DemoQA.Tests;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using SeleniumAdvance.Pages.RandomPagesTests.AutomationPracticeRegistration.Objects;
using System.IO;

namespace SeleniumAdvance.Pages.RandomPagesTests.AutomationPracticeRegistration
{
    [TestFixture]
    class AutomationPracticeTest : BaseTest
    {
        private AutomationPracticeObjects _page;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");           
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
        public void AutomationPracticeRegistration()
        {

            #region StartOfTest
            _page = new AutomationPracticeObjects(Driver);

            _page.signIn.Click();
            _page.emailAdressField.SendKeys("asgasgasgasgagas@abv.bg");
            _page.createAccountButton.Click();          

            _page.AssertThatAccountFieldIsFilled();                     

            #endregion EndOfTest
        }
    }
}
