﻿using DemoQA.Tests;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using SeleniumAdvance.Pages.RandomPagesTests.AutomationQA.Objects;
using System;
using System.Collections.Generic;
using System.IO;
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
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string dirPath = Path.GetFullPath(@"..\..\..\", Directory.GetCurrentDirectory());
                var screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                screenshot.SaveAsFile($"{dirPath}\\Screenshots\\{TestContext.CurrentContext.Test.FullName}.png", ScreenshotImageFormat.Png);
            }
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
