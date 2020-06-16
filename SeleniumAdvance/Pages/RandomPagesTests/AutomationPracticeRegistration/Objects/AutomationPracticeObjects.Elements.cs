using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumAdvance.Pages.RandomPagesTests.GoogleSearch;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumAdvance.Pages.RandomPagesTests.AutomationPracticeRegistration.Objects
{
    public partial class AutomationPracticeObjects : BasePage
    {
        public AutomationPracticeObjects(IWebDriver driver)
            : base(driver)
        {

        }

        public IWebElement signIn => Driver.FindElement(By.ClassName("login"));       

        public IWebElement emailAdressField => Driver.FindElement(By.Id("email_create"));
        
        public IWebElement createAccountButton => Driver.FindElement(By.CssSelector("#SubmitCreate"));
        
        public IWebElement shownEmail => Driver.FindElement(By.Id("email"));

        public IWebElement lastElement => Wait.Until(ExpectedConditions.ElementExists(By.Id("email")));
    }
}
