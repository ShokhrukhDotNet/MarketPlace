using System;
using System.Linq;
using System.Threading.Tasks;
using MarketPlace.Api.Brokers;
using MarketPlace.Api.Models.Cities;

namespace MarketPlace.Api.Services.Foundations.Cities
{
    public class CityService : ICityService
    {
        private readonly IStorageBroker storageBroker;

        public CityService(
            IStorageBroker storageBroker) =>
                this.storageBroker = storageBroker;

        public async ValueTask<City> AddCityAsync(City city) =>
            await this.storageBroker.InsertCityAsync(city);

        public async ValueTask<City> RetrieveCityByIdAsync(Guid cityId) =>
            await this.storageBroker.SelectCityByIdAsync(cityId);

        public IQueryable<City> RetrieveAllCities() =>
            this.storageBroker.SelectAllCities();

        public async ValueTask<City> ModifyCityAsync(City city) =>
            await this.storageBroker.UpdateCityAsync(city);

        public async ValueTask<City> RemoveCityByIdAsync(Guid cityId)
        {
            City maybeCity =
                await this.storageBroker.SelectCityByIdAsync(cityId);

            return await this.storageBroker.DeleteCityAsync(maybeCity);
        }
    }
}
