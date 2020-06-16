using DemoQA.Tests;
using NUnit.Framework;
using SeleniumAdvance.Pages.DemoQA.SelectableTests.Objects;
using System;
using System.Collections.Generic;
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
