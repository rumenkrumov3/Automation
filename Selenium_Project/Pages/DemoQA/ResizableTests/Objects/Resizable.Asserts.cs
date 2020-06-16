using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumAdvance.Pages.DemoQA.ResizableTests.Objects
{
    public partial class Resizable
    {
        public void AssertResizable(Boolean resizableWindowBefore, Boolean resizableWindowAfter)
        {
            Assert.That(resizableWindowBefore, Is.EqualTo(resizableWindowAfter));
        }

    }
}
