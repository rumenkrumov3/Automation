using DemoQA.Tests;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using SeleniumAdvance.Pages.DemoQA.DroppableTests.Objects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace SeleniumAdvance.Pages.DemoQA.DroppableTests
{
    [TextFixture]
    public class DroppableTest : BaseTest
    {
        private Droppable _page;
        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://demoqa.com/droppable");
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
        public void DroppableExercise1Simple()
        {
            //Checks colors of target before and after drop
            _page = new Droppable(Driver);    

            var colorOfTargetBefore = _page.targetSimple.GetCssValue("background-color");

            Builder
                .DragAndDrop(_page.sourceSimple, _page.targetSimple)
                .Perform();

            var colorOfTargetAfter = _page.targetSimple.GetCssValue("background-color");

            _page.AssertSimple(colorOfTargetBefore, colorOfTargetAfter);            
        }
        [Test]
        public void DroppableExercise2RevertDraggable()
        {
            //Checks whether the element will return to his start place
            _page = new Droppable(Driver);
            _page.RevertDraggable.Click();
            
            var sourceLocationX = _page.sourceRevert.Location.X;
            var sourceLocationY = _page.sourceRevert.Location.Y;

            Builder
                .DragAndDrop(_page.sourceRevert, _page.targetRevert)
                .Perform();

            Thread.Sleep(1000);

            var sourceLocationXAfter = _page.sourceRevert.Location.X;
            var sourceLocationYAfter = _page.sourceRevert.Location.Y;

            Assert.AreEqual(sourceLocationX, sourceLocationXAfter);
            Assert.AreEqual(sourceLocationY, sourceLocationYAfter);
        }
        [Test]
        public void DroppableExercise3Accept()
        {
            //Checks the color of target when source element is accepted
            _page = new Droppable(Driver);
            _page.Accept.Click();

            Builder
                .DragAndDrop(_page.sourceAccept, _page.targetAccept)
                .Perform();


            var expectedColor = "rgba(70, 130, 180, 1)";
            var colorOfTarget = _page.targetAccept.GetCssValue("background-color");

            Assert.AreEqual(expectedColor, colorOfTarget);
        }
    }
}
