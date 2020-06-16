using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumAdvance.Pages.RandomPagesTests.GoogleSearch;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumAdvance.Pages.AutomationPracticeRegistration.Objects
{
    public partial class ErrorThrows : BasePage
    {
        public ErrorThrows(IWebDriver driver) :
             base(driver)
        {

        }

        public IWebElement emailAdressField => Driver.FindElement(By.Id("email_create"));

        public IWebElement createAccountButton => Driver.FindElement(By.CssSelector("#SubmitCreate"));

        public IWebElement Title => Driver.FindElement(By.Id("id_gender1"));       

        public IWebElement FirstName => Driver.FindElement(By.Id("customer_firstname"));

        public IWebElement LastName => Driver.FindElement(By.Id("customer_lastname"));

        public IWebElement Password => Driver.FindElement(By.Id("passwd"));

        public IWebElement Days => Driver.FindElement(By.Id("days"));      
            
        public IWebElement Months => Driver.FindElement(By.XPath("//*[@id='months']"));       

        public IWebElement Year => Driver.FindElement(By.Id("years"));
        
        public IWebElement Address => Driver.FindElement(By.Id("address1"));

        public IWebElement City => Driver.FindElement(By.Id("city"));

        public IWebElement State => Driver.FindElement(By.Id("id_state"));    

        public IWebElement PostCode => Driver.FindElement(By.Id("postcode"));

        public IWebElement MobilePhone => Driver.FindElement(By.Id("phone_mobile"));
        
        public IWebElement AssignAddress => Driver.FindElement(By.Id("alias"));
        
        public IWebElement SubmitButton => Driver.FindElement(By.Id("submitAccount"));
        
    }
}
