using OpenQA.Selenium;
using SeleniumAdvance.Pages.AutomationPracticeRegistration.AutomationPracticeFactory;
using SeleniumAdvance.Pages.AutomationPracticeRegistration.AutomationPracticeModel;
using SeleniumAdvance.Pages.RandomPagesTests.GoogleSearch;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumAdvance.Pages.AutomationPracticeRegistration.Objects
{
    public class AutomationPracticeFillForm : BasePage
    {
        private AutomationPracticeRegistrationModel _user;
        private ErrorThrows _page;        

        public AutomationPracticeFillForm(IWebDriver driver) : base(driver)
        {
        }

        public void FillForm(AutomationPracticeRegistrationModel _user)
        {
            _page = new ErrorThrows(Driver);           

            _page.emailAdressField.SendKeys(_user.Email);
            _page.createAccountButton.Click();
            _page.Title.Click();
            _page.FirstName.SendKeys(_user.FirstName);
            _page.LastName.SendKeys(_user.LastName);
            _page.Password.SendKeys(_user.Password);
            _page.Days.SendKeys("1");
            _page.Months.SendKeys("February");
            _page.Year.SendKeys("1990");
            _page.Address.SendKeys(_user.Address);
            _page.City.SendKeys(_user.City);
            _page.State.SendKeys(_user.State);
            _page.PostCode.SendKeys(_user.PostCode);
            _page.MobilePhone.SendKeys(_user.MobilePhone);
            _page.AssignAddress.SendKeys(_user.AssingAdress);
            _page.SubmitButton.Click();
        }
    }
}
