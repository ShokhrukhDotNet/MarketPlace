using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using MarketPlace.Api.Models.Cars;

namespace MarketPlace.Api.Models.Brands
{
    public class Brand
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string LogoUrl { get; set; }
        public string Description { get; set; }
        [JsonIgnore]
        public List<Car>? Cars { get; set; }
    }
}
