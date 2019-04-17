namespace Miguitas.Common.Models
{
    using Newtonsoft.Json;
    using System;

    public class Product
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("price")]
        public decimal Price { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("isAvailabe")]
        public bool IsAvailabe { get; set; }

        [JsonProperty("stock")]
        public double Stock { get; set; }

        [JsonProperty("imageFullPath")]
        public Uri ImageFullPath { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }
    }

}
