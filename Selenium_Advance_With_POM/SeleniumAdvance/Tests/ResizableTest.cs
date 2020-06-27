using DemoQA.Tests;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using SeleniumAdvance.Pages.DemoQA.ResizableTests.Objects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SeleniumAdvance.Pages.DemoQA.ResizableTests
{
    [TextFixture]
    public class ResizableTest : BaseTest
    {
        private Resizable _page;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://demoqa.com/resizable");
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
        public void ResizableExercise1()
        {
            //Resize to maximum and checks           
            _page = new Resizable(Driver);

            var resizableWindowBefore = _page.resizableWindow.GetAttribute("style").Contains("width: 200px");

            Builder
                .ClickAndHold(_page.resizableArrow)
                .MoveByOffset(300, 100)
                .Perform();

            var resizableWindowAfter = _page.resizableWindow.GetAttribute("style").Contains("width: 500px");

            _page.AssertResizable(resizableWindowBefore, resizableWindowAfter);
        }
        [Test]
        public void ResizableExercise2()
        {
            //Resize to maximum and checks           
            _page = new Resizable(Driver);

            var resizableWindowBefore = _page.resizableWindow.GetAttribute("style").Contains("width: 200px");

            Builder
                .ClickAndHold(_page.resizableArrow)
                .MoveByOffset(-50, -50)
                .Perform();

            var resizableWindowAfter = _page.resizableWindow.GetAttribute("style").Contains("width: 150px");

            _page.AssertResizable(resizableWindowBefore, resizableWindowAfter);
        }
    }
}
