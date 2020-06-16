using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumAdvance.Pages.RandomPagesTests.GoogleSearch;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumAdvance.Pages.AutomationPracticeRegistration.Objects
{
    public partial class ErrorThrows : BasePage
    {
        public void AssertAlert(string expectedMessage)
        {
            IWebElement Alert = Driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div"));

            var actualAlertText = Alert.Text;

            Assert.AreEqual(expectedMessage, actualAlertText);
        }
    }
}
