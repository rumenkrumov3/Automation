using DemoQA.Tests;
using NUnit.Framework;
using SeleniumAdvance.Pages.DemoQA.SortableTests.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumAdvance.Pages.DemoQA.SortableTests
{
    [TextFixture]
    public class SortableTest : BaseTest
    {
        private Sortable _page;
        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://demoqa.com/sortable");
        }
        public void TearDown()
        {
            Driver.Quit();
        }
        [Test]
        public void SortableExercise1List()
        {
            //Moving source ater targetBox, because if we try to move it to target one, source is moved to the place before it
            _page = new Sortable(Driver);
            
            var sourceBoxXBefore = _page.sourceBox.Location.X;
            var sourceBoxYBefore = _page.sourceBox.Location.Y;
            var targetBoxXBefore = _page.targetBox.Location.X;
            var targetBoxYBefore = _page.targetBox.Location.Y;

            Builder
                .DragAndDrop(_page.sourceBox, _page.boxAfterTarget)
                .Perform();           

            var sourceBoxXAfter = _page.sourceBoxAfterElement.Location.X;
            var sourceBoxYAfter = _page.sourceBoxAfterElement.Location.Y;

            _page.SortableAreEqual(sourceBoxXAfter, sourceBoxYAfter);
        }
        [Test]
        public void SortableExercise2List()
        {
            //Moving source to the target and checks whether source is placed before target
            _page = new Sortable(Driver);

            var sourceBoxXBefore = _page.sourceBox.Location.X;
            var sourceBoxYBefore = _page.sourceBox.Location.Y;
            var targetBoxXBefore = _page.targetBox.Location.X;
            var targetBoxYBefore = _page.targetBox.Location.Y;
            var boxBeforeTargetBoxX = _page.boxBeforeTargetBox.Location.X;
            var boxBeforeTargetBoxY = _page.boxBeforeTargetBox.Location.Y;

            Builder
                .DragAndDrop(_page.sourceBox, _page.targetBox)
                .Perform();         

            var targetBoxXAfter = _page.targetBoxAfterElement.Location.X;
            var targetBoxYAfter = _page.targetBoxAfterElement.Location.Y;

            _page.Sortable2AreEqual(targetBoxXAfter, targetBoxYAfter, boxBeforeTargetBoxX, boxBeforeTargetBoxY);



        }
    }
}
