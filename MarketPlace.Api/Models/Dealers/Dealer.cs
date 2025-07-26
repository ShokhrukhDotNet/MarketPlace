using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using MarketPlace.Api.Models.Cars;

namespace MarketPlace.Api.Models.Dealers
{
    public class Dealer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public decimal Rating { get; set; }
        public Guid CityId { get; set; }
        [JsonIgnore]
        public List<Car>? Cars { get; set; }
    }
}
