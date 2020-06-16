using AutoFixture;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Security.Cryptography;
using System.Threading;

namespace BasicSoftUniTests
{
    [TestFixture]
    public class BasicSoftUniTests
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        string _password = "";

        [SetUp]
        public void SetUp()
        {           
            _driver = new ChromeDriver();          
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(60));
        }
        
        [TearDown] 
        public void TearDown()
        {
            _driver.Quit();
        }
        
        [Test]
        public void GoogleSearch()
        {
             
            _driver.Url = "http://www.google.com";

            #region StartOfTest

            IWebElement searchTextField =_wait.Until<IWebElement>(d => d.FindElement(By.CssSelector("#tsf > div:nth-child(2) > div.A8SBwf > div.RNNXgb > div > div.a4bIc > input")));
            searchTextField.SendKeys("selenium");

            IWebElement firstAvailableChoice= _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName("sbl1")));
            firstAvailableChoice.Click();

            IWebElement firstChoiceOfSearchedPage = _wait.Until<IWebElement>(d => d.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div.r > a > h3")));
            firstChoiceOfSearchedPage.Click();
            
            string actualTitle = _driver.Title;
            string expectedTitle = "SeleniumHQ Browser Automation";

            Assert.IsTrue(_wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TitleContains("SeleniumHQ Browser Automation")), "SeleniumHQ Browser Automation");

            #endregion EndOfTest
        }
        [Test]
        public void QAAutomation()
        {
            _driver.Url = "http://www.softuni.bg";

            #region StartOfTest

            IWebElement coursesField = _wait.Until<IWebElement>(d => d.FindElement(By.CssSelector("#header-nav > div.toggle-nav.toggle-holder > ul > li:nth-child(2) > a > span")));
            coursesField.Click();

            IWebElement QAAutomationCourse = _wait.Until<IWebElement>(d => d.FindElement(By.CssSelector("#header-nav > div.toggle-nav.toggle-holder > ul > li.nav-item.dropdown-item.open > div > div > div.row.no-margin-offset.courses-and-modules-wrapper > div.col-md-8.open-courses-wrapper.open-courses-background > div > div:nth-child(2) > ul:nth-child(4) > div:nth-child(1) > ul > li > a")));
            QAAutomationCourse.Click();

            IWebElement headingText = _wait.Until<IWebElement>(d => d.FindElement(By.XPath("//h1[contains(text(), 'QA Automation - май 2020')]")));

            string actualText = headingText.Text;
            string expectedText = "QA Automation - май 2020";

            Assert.AreEqual(expectedText, actualText, string.Format("Strings are not equal"));

            #endregion EndOfTest
        }
        [Test]
        public void AutomationPracticeRegistration()
        {
            _driver.Url = "http://automationpractice.com/index.php";

            #region StartOfTest

            //var fixture = new Fixture();
            //var mail = fixture.Create(string);
            IWebElement signIn = _wait.Until<IWebElement>(d => d.FindElement(By.ClassName("login")));
            signIn.Click();

            IWebElement emailAdressField = _wait.Until<IWebElement>(d => d.FindElement(By.Id("email_create")));
            emailAdressField.SendKeys("asdasdasd@abv.bg");

            IWebElement createAccountButton = _wait.Until<IWebElement>(d => d.FindElement(By.CssSelector("#SubmitCreate")));
            createAccountButton.Click();    
            
            string expectedEmail = "asdasdasd@abv.bg";

            Assert.IsTrue(_wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TextToBePresentInElementValue(By.Id("email"), expectedEmail)));

            #endregion EndOfTest
        }
        [Test]
        public void AutomationPracticeRegistrationNegative()
        {
            _driver.Url = "http://automationpractice.com/index.php";

            #region StartOfTest

            IWebElement signIn = _wait.Until<IWebElement>(d => d.FindElement(By.ClassName("login")));
            signIn.Click();

            IWebElement emailAdressField = _wait.Until<IWebElement>(d => d.FindElement(By.Id("email_create")));
            emailAdressField.SendKeys("asdasdasdabv.bg");

            IWebElement createAccountButton = _wait.Until<IWebElement>(d => d.FindElement(By.CssSelector("#SubmitCreate")));
            createAccountButton.Click();

            IWebElement failure = _wait.Until<IWebElement>(d => d.FindElement(By.CssSelector("#create_account_error > ol > li")));

            string actualFailureText = failure.Text;
            string expectedFailureText = "Invalid email address.";

            Assert.That(expectedFailureText, Is.EqualTo(actualFailureText));

            #endregion EndOfTest
        }
    }
}
