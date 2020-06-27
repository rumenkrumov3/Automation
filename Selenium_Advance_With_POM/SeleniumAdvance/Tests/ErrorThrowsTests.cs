using DemoQA.Tests;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using SeleniumAdvance.Pages.AutomationPracticeRegistration.AutomationPracticeFactory;
using SeleniumAdvance.Pages.AutomationPracticeRegistration.AutomationPracticeModel;
using SeleniumAdvance.Pages.AutomationPracticeRegistration.Objects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SeleniumAdvance.Pages.AutomationPractice
{
    [TestFixture]
    public class ErrorThrowsTests : BaseTest
    {
        private AutomationPracticeRegistrationModel _user;
        private ErrorThrows _page;
        private AutomationPracticeFillForm _fill;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=authentication&back=my-account");            
            _page = new ErrorThrows(Driver);
            _fill = new AutomationPracticeFillForm(Driver);
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
        public void ErrorisThrown_When_FirstNameIsEmpty()
        {
            _user = AutomationPracticeRegistrationFactory.Create();            
            _user.FirstName = string.Empty;

            _fill.FillForm(_user);

            _page.AssertAlert("There is 1 error\r\nfirstname is required.");

        }
        
        [Test]
        public void ErrorisThrown_When_LastNameIsEmpty()
        {
            _user = AutomationPracticeRegistrationFactory.Create();
            _user.LastName = string.Empty;

            _fill.FillForm(_user);

            _page.AssertAlert("There is 1 error\r\nlastname is required.");

        }
        [Test]
        public void ErrorisThrown_When_CityIsEmpty()
        {
            _user = AutomationPracticeRegistrationFactory.Create();
            _user.City = string.Empty;

            _fill.FillForm(_user);

            _page.AssertAlert("There is 1 error\r\ncity is required.");

        }
        [Test]
        public void ErrorisThrown_When_PostCodeIsEmpty()
        {
            _user = AutomationPracticeRegistrationFactory.Create();
            _user.PostCode = string.Empty;

            _fill.FillForm(_user);

            _page.AssertAlert("There is 1 error\r\nThe Zip/Postal code you've entered is invalid. It must follow this format: 00000");

        }
        [Test]
        public void ErrorisThrown_When_PasswordIsEmpty()
        {
            _user = AutomationPracticeRegistrationFactory.Create();
            _user.Password = string.Empty;

            _fill.FillForm(_user);

            _page.AssertAlert("There is 1 error\r\npasswd is required.");

        }
    }
}
