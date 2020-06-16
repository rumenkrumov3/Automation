using NUnit.Framework;
using SeleniumAdvance.Pages.RandomPagesTests.GoogleSearch;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumAdvance.Pages.DemoQA.DraggableTests.Objects
{
    public partial class Draggable : BasePage
    {
        public void AssertSimple(int sourcePositionX, int sourcePositionY, int sourcePositionXAfter, int sourcePositionYAfter)
        {
            Assert.AreEqual(sourcePositionX + 100, sourcePositionXAfter);
            Assert.AreEqual(sourcePositionY + 100, sourcePositionYAfter);
        }

        public void AssertRestricted(int sourcePositionX, int sourcePositionY, int sourcePositionXAfter, int sourcePositionYAfter)
        {
            Assert.AreNotEqual(sourcePositionXAfter, sourcePositionX);
            Assert.AreEqual(sourcePositionY, sourcePositionYAfter);
        }

        public void AssertContainer(int sourcePositionX, int sourcePositionY, int sourcePositionXAfter, int sourcePositionYAfter)
        {
            Assert.IsTrue(sourcePositionXAfter - sourcePositionX == 200);
            Assert.IsTrue(sourcePositionYAfter - sourcePositionY == 100);
        }
    }
}
