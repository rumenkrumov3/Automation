using AutoFixture;
using SeleniumAdvance.Pages.AutomationPracticeRegistration.AutomationPracticeModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumAdvance.Pages.AutomationPracticeRegistration.AutomationPracticeFactory
{
    public static class AutomationPracticeRegistrationFactory
    {
        public static AutomationPracticeRegistrationModel Create()
        {
            var fixture = new Fixture();
            var email = fixture.Create<string>();

            return new AutomationPracticeRegistrationModel
            {
                FirstName = "Rumen",
                LastName = "Krumov",
                Password = "Q1w2e3r4t5y6",
                Address = "asgasgasgasgasgas",
                City = "Sofia",
                State = "Alaska",
                PostCode = "17000",
                MobilePhone = "125125125125",
                AssingAdress = "ahashashashash",
                Email = $"{email}@abv.bg"
            };
        }
    }
}
