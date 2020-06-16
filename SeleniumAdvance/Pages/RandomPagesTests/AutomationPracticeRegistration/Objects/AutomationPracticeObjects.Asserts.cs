using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumAdvance.Pages.RandomPagesTests.GoogleSearch;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SeleniumAdvance.Pages.RandomPagesTests.AutomationPracticeRegistration.Objects
{
    public partial class AutomationPracticeObjects : BasePage
    {       
        public void AssertThatAccountFieldIsFilled()
        {
            Thread.Sleep(2000);
            
            string expectedEmail = "asgasgasgasgagas@abv.bg";
            string actualEmail = shownEmail.GetAttribute("value");
            
            Assert.AreEqual(actualEmail ,expectedEmail);
        }
    }
}
