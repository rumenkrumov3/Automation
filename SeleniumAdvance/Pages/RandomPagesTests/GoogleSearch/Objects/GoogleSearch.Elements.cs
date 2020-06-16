using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumAdvance.Pages.RandomPagesTests.GoogleSearch
{
    public partial class GoogleSearch : BasePage
    {
        public GoogleSearch(IWebDriver driver):
            base(driver)
        {

        }
        public IWebElement searchTextField => Driver.FindElement(By.CssSelector("#tsf > div:nth-child(2) > div.A8SBwf > div.RNNXgb > div > div.a4bIc > input"));
        
        public IWebElement firstAvailableChoice => Driver.FindElement(By.ClassName("sbl1"));
        
        public IWebElement firstChoiceOfSearchedPage => Driver.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div.r > a > h3"));
        
    }
}
