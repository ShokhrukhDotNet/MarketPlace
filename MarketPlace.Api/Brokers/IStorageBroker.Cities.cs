using System;
using System.Linq;
using System.Threading.Tasks;
using MarketPlace.Api.Models.Cities;

namespace MarketPlace.Api.Brokers
{
    public partial interface IStorageBroker
    {
        ValueTask<City> InsertCityAsync(City city);
        IQueryable<City> SelectAllCities();
        ValueTask<City> SelectCityByIdAsync(Guid cityId);
        ValueTask<City> UpdateCityAsync(City city);
        ValueTask<City> DeleteCityAsync(City city);
    }
}
