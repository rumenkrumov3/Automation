using NUnit.Framework;
using SeleniumAdvance.Pages.RandomPagesTests.GoogleSearch;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SeleniumAdvance.Pages.DemoQA.DroppableTests.Objects
{
    public partial class Droppable : BasePage
    {
        public void AssertSimple(string colorOfTargetBefore, string colorOfTargetAfter)
        {
            Assert.AreNotEqual(colorOfTargetBefore, colorOfTargetAfter);
        }

        public void AssertRevert(int sourceLocationX, int sourceLocationY, int sourceLocationXAfter, int sourceLocationYAfter)
        {           
            Assert.AreEqual(sourceLocationX, sourceLocationXAfter);
            Assert.AreEqual(sourceLocationY, sourceLocationYAfter);
        }

        public void AssertAccept(string expectedColor, string colorOfTarget)
        {
            Assert.AreEqual(expectedColor, colorOfTarget);
        }
    }
}
