using System;

namespace MarketPlace.Api.Models.Cars
{
    public class Car
    {
        public Guid Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public int Mileage { get; set; }
        public string Color { get; set; }
        public string FuelType { get; set; }
        public string Transmission { get; set; }
        public bool IsAvailable { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public Guid DealerId { get; set; }
        public Guid BrandId { get; set; }
    }
}
