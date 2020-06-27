﻿using DemoQA.Tests;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using SeleniumAdvance.Pages.DemoQA.SelectableTests.Objects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SeleniumAdvance.Pages.DemoQA.SelectableTests
{
    [TextFixture]
    public class SelectableTest : BaseTest
    {
        private Selectable _page;
        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://demoqa.com/selectable");
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
        public void SelectableExercise1()
        {
            _page = new Selectable(Driver);

            var colorBeforeInteraction = _page.firstButton.GetCssValue("color");

            Builder
                .Click(_page.firstButton)
                .Perform();

            var colorAfterInteraction = _page.firstButton.GetCssValue("color");

            _page.SelectableAreNotEqual(colorBeforeInteraction, colorAfterInteraction);
        }
        [Test]
        public void SelectableExercise2()
        {
            _page = new Selectable(Driver);
           
            Builder
                .Click(_page.firstButton)
                .Click(_page.secondButton)
                .Perform();

            var colorOfFirstButton = _page.firstButton.GetCssValue("color");
            var colorOfSecondButton = _page.secondButton.GetCssValue("color");

            _page.SelectableAreEqual(colorOfFirstButton, colorOfSecondButton);
        }
    }
}
