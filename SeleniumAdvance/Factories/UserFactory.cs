using AutoFixture;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumAdvance
{
    public static class UserFactory
    {
        public static RegistrationUser GetValidUser()
        {
            var fixture = new Fixture();
            var dateTime = fixture.Create<DateTime>();
            var random = new Random();

            return new RegistrationUser
            {
                Password = fixture.Create<string>(),
                Date = dateTime.Day.ToString(),
                Month = dateTime.Month.ToString(),
                Year = dateTime.Year.ToString(),
                Email = fixture.Create<string>(),
                Address = fixture.Create<string>(),
                City = fixture.Create<string>(),
                State = random.Next(1, 50).ToString(),
                PostCode = random.Next(10000, 99999).ToString(),
                MobilePhone = fixture.Create<int>().ToString(),
                Gender = "Male",              

            };
        }

    }
}
