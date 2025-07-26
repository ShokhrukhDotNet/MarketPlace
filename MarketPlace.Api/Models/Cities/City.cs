using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using MarketPlace.Api.Models.Dealers;

namespace MarketPlace.Api.Models.Cities
{
    public class City
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        [JsonIgnore]
        public List<Dealer>? Dealers { get; set; }
    }
}
