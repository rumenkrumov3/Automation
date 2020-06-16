using DemoQA.Tests;
using NUnit.Framework;
using SeleniumAdvance.Pages.RandomPagesTests.AutomationPracticeRegistration.Objects;

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
