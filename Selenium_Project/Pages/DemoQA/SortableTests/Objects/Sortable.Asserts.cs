using NUnit.Framework;
using SeleniumAdvance.Pages.RandomPagesTests.GoogleSearch;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumAdvance.Pages.DemoQA.SortableTests.Objects
{
    public partial class Sortable : BasePage
    {
        public void SortableAreEqual(int sourceBoxXAfter, int sourceBoxYAfter)
        {
            Assert.AreEqual(359, sourceBoxXAfter, 3);
            Assert.AreEqual(450, sourceBoxYAfter, 3);
        }
        public void Sortable2AreEqual(int targetBoxXAfter, int targetBoxYAfter, int boxBeforeTargetBoxX, int boxBeforeTargetBoxY)
        {
            Assert.AreEqual(targetBoxXAfter, boxBeforeTargetBoxX);
            Assert.AreEqual(targetBoxYAfter, boxBeforeTargetBoxY);
        }
    }
}
