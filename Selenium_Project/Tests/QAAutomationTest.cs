using DemoQA.Tests;
using NUnit.Framework;
using SeleniumAdvance.Pages.RandomPagesTests.AutomationQA.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumAdvance.Pages.RandomPagesTests.AutomationQA
{
    [TestFixture]
    public class QAAutomationTest : BaseTest
    {
        private QAAutomation _page;
        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Navigate().GoToUrl("https://softuni.bg/trainings/2550/qa-automation-may-2020");           
        }
        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
        [Test]
        public void QAAutomation()
        {
            #region StartOfTest 
            
            _page = new QAAutomation(Driver);

            _page.AssertHeadingText(Driver);

            #endregion EndOfTest
        }
    }
}
