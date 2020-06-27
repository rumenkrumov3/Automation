using HttpRequests.Model;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Encodings.Web;
using System.Threading;

namespace HttpRequests
{
    public class Tests
    {
        private RestClient _restClient;
        private HouseholdRequest _householdRequest;
        private HouseholdResponse _householdResponse;
        private UserRequest _user1;
        private UserResponse _user1r;
        private UserRequest _user2;
        private UserResponse _user2r;

        [SetUp]
        public void Setup()
        {
            _restClient = new RestClient();

            // _restClient.AddDefaultQueryParameter;
            _restClient.BaseUrl = new Uri("http://localhost:3000");
            _restClient.AddDefaultHeader("G-Token", "ROM831ESV");
        }

        [Test]
        [Order(1)]
        public void PostHousehold()
        {
            var request = new RestRequest("/households");

            _householdRequest = new HouseholdRequest()
            {
                Name = "asdd",
                Title = "dsaa",
                Author = "asdd",
                Isbn = "10",
                PublicationDate = "2020-25-06"

            };

            var HouseInJson = Newtonsoft.Json.JsonConvert.SerializeObject(_householdRequest);
            request.AddParameter("application/json", HouseInJson, ParameterType.RequestBody);

            var response = _restClient.Post(request);

            _householdResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<HouseholdResponse>(response.Content);

            Thread.Sleep(500);
        }
        [Test]
        [Order(2)]
        public void PostUser()
        {
            var request = new RestRequest("/users");

            _user1 = new UserRequest()
            {
                Email = "user1@abv.bg",
                FirstName = "User1",
                LastName = "Userov1",
                HouseholdId = _householdResponse.Id
            };

            var userInJson = Newtonsoft.Json.JsonConvert.SerializeObject(_user1);
            request.AddParameter("application/json", userInJson, ParameterType.RequestBody);

            var response = _restClient.Post(request);

            _user1r = Newtonsoft.Json.JsonConvert.DeserializeObject<UserResponse>(response.Content);

            Thread.Sleep(500);
        }
        [Test]
        [Order(3)]
        public void PostUser2()
        {
            var request = new RestRequest("/users");

            _user2 = new UserRequest()
            {
                Email = "user2@abv.bg",
                FirstName = "User2",
                LastName = "Userov2",
                HouseholdId = _householdResponse.Id
            };

            var userInJson = Newtonsoft.Json.JsonConvert.SerializeObject(_user2);
            request.AddParameter("application/json", userInJson, ParameterType.RequestBody);

            var response = _restClient.Post(request);

            _user2r = Newtonsoft.Json.JsonConvert.DeserializeObject<UserResponse>(response.Content);

            Thread.Sleep(500);
        }
        [Test]
        [Order(4)]
        public void PostBooks1()
        {
            var request = new RestRequest($"/wishlists/{_user1r.WishlistId}/books/5");

            var response = _restClient.Post(request);

            request = new RestRequest($"/wishlists/{_user1r.WishlistId}/books/6");

            response = _restClient.Post(request);

            Thread.Sleep(500);
        }
        [Test]
        [Order(5)]
        public void PostBooks2()
        {
            var request = new RestRequest($"/wishlists/{_user2r.WishlistId}/books/5");

            var response = _restClient.Post(request);

            request = new RestRequest($"/wishlists/{_user2r.WishlistId}/books/5");

            response = _restClient.Post(request);

            Thread.Sleep(500);
        }
        [Test]
        [Order(6)]
        public void GetWishlishForHousehold()
        {
            var request = new RestRequest($"/households/{_householdResponse.Id}/wishlistBooks");

            var response = _restClient.Get(request);

        }

    }
}