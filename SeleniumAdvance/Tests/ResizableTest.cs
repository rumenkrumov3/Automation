using DemoQA.Tests;
using NUnit.Framework;
using SeleniumAdvance.Pages.DemoQA.ResizableTests.Objects;
using System;
using System.Collections.Generic;
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
