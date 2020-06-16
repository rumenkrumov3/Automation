using DemoQA.Tests;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumAdvance.Pages.DemoQA.DraggableTests.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumAdvance.Pages.DemoQA.DraggableTests
{
    [TestFixture]
    public class DraggableTests : BaseTest
    {
        private Draggable _page;
        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://demoqa.com/dragabble");
        }
        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
        [Test]
        public void DraggableExercise1Simple()
        {
            //Checks position of source when is moved with some offset          
            _page = new Draggable(Driver);

            var sourcePositionX = _page.source.Location.X;
            var sourcePositionY = _page.source.Location.Y;

            Builder
                .ClickAndHold(_page.source)
                .MoveByOffset(100, 100)
                .Perform();

            var sourcePositionXAfter = _page.source.Location.X;
            var sourcePositionYAfter = _page.source.Location.Y;

            _page.AssertSimple(sourcePositionX, sourcePositionY, sourcePositionXAfter, sourcePositionYAfter);
        }
       
        [Test]
        public void DraggableExercise2AxisRestricted()
        {
            //Checks whether first element will be moved only on X Axis (positive and negative in one)

            _page = new Draggable(Driver);
            _page.AxisRestricted.Click();

            var sourcePositionX = _page.sourceRestricted.Location.X;
            var sourcePositionY = _page.sourceRestricted.Location.Y;

            Builder
                .ClickAndHold(_page.sourceRestricted)
                .MoveByOffset(100, 100)
                .Perform();

            var sourcePositionXAfter = _page.sourceRestricted.Location.X;
            var sourcePositionYAfter = _page.sourceRestricted.Location.Y;

            _page.AssertRestricted(sourcePositionX, sourcePositionY, sourcePositionXAfter, sourcePositionYAfter);
        }
        [Test]
        public void DraggableExercise3ContainerRestricted()
        {
            //Checks positions            
            _page = new Draggable(Driver);
            _page.ContainerRestricted.Click();

            var sourcePositionX = _page.sourceContainer.Location.X;
            var sourcePositionY = _page.sourceContainer.Location.Y;

            Builder
                .ClickAndHold(_page.sourceContainer)
                .MoveByOffset(200, 100)
                .Perform();

            var sourcePositionXAfter = _page.sourceContainer.Location.X;
            var sourcePositionYAfter = _page.sourceContainer.Location.Y;

            _page.AssertContainer(sourcePositionX, sourcePositionY, sourcePositionXAfter, sourcePositionYAfter);
        }
        
    }
}
