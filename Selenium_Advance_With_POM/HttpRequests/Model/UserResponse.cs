namespace HttpRequests.Model
{
    using Newtonsoft.Json;
    using System;

    public partial class UserResponse
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("wishlistId")]
        public long WishlistId { get; set; }

        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("householdId")]
        public long HouseholdId { get; set; }
    }
}