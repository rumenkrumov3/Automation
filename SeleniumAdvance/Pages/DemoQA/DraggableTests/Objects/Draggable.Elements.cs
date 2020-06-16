using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumAdvance.Pages.RandomPagesTests.GoogleSearch;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumAdvance.Pages.DemoQA.DraggableTests.Objects
{
    public partial class Draggable : BasePage
    {
        public Draggable(IWebDriver driver) 
            : base(driver)
        {

        }
       
        public IWebElement source => Driver.FindElement(By.CssSelector("#dragBox"));

        public IWebElement AxisRestricted => Driver.FindElement(By.CssSelector("#draggableExample-tab-axisRestriction"));

        public IWebElement sourceRestricted => Driver.FindElement(By.CssSelector("#restrictedX"));

        public IWebElement ContainerRestricted => Driver.FindElement(By.CssSelector("#draggableExample-tab-containerRestriction"));
        
        public IWebElement sourceContainer => Driver.FindElement(By.CssSelector("#containmentWrapper > div"));

    }
}
