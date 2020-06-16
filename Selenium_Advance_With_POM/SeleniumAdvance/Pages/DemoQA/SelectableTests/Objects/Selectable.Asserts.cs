using NUnit.Framework;
using SeleniumAdvance.Pages.RandomPagesTests.GoogleSearch;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumAdvance.Pages.DemoQA.SelectableTests.Objects
{
    public partial class Selectable : BasePage
    {
        public void SelectableAreNotEqual(string colorAfterInteraction, string colorBeforeInteraction)
        {
            Assert.AreNotEqual(colorBeforeInteraction, colorAfterInteraction);
        }
        public void SelectableAreEqual(string colorOfFirstButton, string colorOfSecondButton)
        {
            Assert.AreEqual(colorOfFirstButton, colorOfSecondButton);
        }
    }
}
