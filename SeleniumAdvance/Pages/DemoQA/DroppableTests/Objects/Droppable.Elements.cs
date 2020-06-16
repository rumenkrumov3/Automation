using OpenQA.Selenium;
using SeleniumAdvance.Pages.RandomPagesTests.GoogleSearch;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumAdvance.Pages.DemoQA.DroppableTests.Objects
{
    public partial class Droppable : BasePage
    {
        public Droppable(IWebDriver driver)
            : base(driver)
        {

        }

        public IWebElement sourceSimple => Driver.FindElement(By.CssSelector("#draggable"));

        public IWebElement targetSimple => Driver.FindElement(By.CssSelector("#droppable"));

        public IWebElement RevertDraggable => Driver.FindElement(By.CssSelector("#droppableExample-tab-revertable"));      

        public IWebElement sourceRevert => Driver.FindElement(By.CssSelector("#revertable"));

        public IWebElement targetRevert => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/div/div[4]/div/div[2]"));

        public IWebElement Accept => Driver.FindElement(By.CssSelector("#droppableExample-tab-accept"));   

        public IWebElement sourceAccept => Driver.FindElement(By.CssSelector("#acceptable"));
        
        public IWebElement targetAccept => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/div/div[2]/div/div[2]"));
    }
}
