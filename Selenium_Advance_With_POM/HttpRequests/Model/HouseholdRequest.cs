namespace HttpRequests.Model
{
    using Newtonsoft.Json;
    using System;

    public class HouseholdRequest
    {
        [JsonProperty("Id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("isbn")]
        public string Isbn { get; set; }

        [JsonProperty("publicationDate")]
        public string PublicationDate { get; set; }
      
    }

    internal class ParseStringConverter
    {
    }
}