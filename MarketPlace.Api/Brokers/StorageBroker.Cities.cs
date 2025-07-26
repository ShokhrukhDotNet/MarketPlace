using System;
using System.Linq;
using System.Threading.Tasks;
using MarketPlace.Api.Models.Cities;
using Microsoft.EntityFrameworkCore;

namespace MarketPlace.Api.Brokers
{
    public partial class StorageBroker
    {
        public DbSet<City> Cities { get; set; }

        public async ValueTask<City> InsertCityAsync(City city) =>
            await InsertAsync(city);

        public IQueryable<City> SelectAllCities() => SelectAll<City>();

        public async ValueTask<City> SelectCityByIdAsync(Guid cityId) =>
            await SelectAsync<City>();

        public async ValueTask<City> UpdateCityAsync(City city) =>
            await UpdateAsync(city);

        public async ValueTask<City> DeleteCityAsync(City city) =>
            await DeleteAsync(city);
    }
}
