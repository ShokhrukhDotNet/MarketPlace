using System;
using System.Linq;
using System.Threading.Tasks;
using MarketPlace.Api.Models.Cities;

namespace MarketPlace.Api.Services.Foundations.Cities
{
    public interface ICityService
    {
        ValueTask<City> AddCityAsync(City city);
        IQueryable<City> RetrieveAllCities();
        ValueTask<City> RetrieveCityByIdAsync(Guid cityId);
        ValueTask<City> RemoveCityByIdAsync(Guid locationId);
        ValueTask<City> ModifyCityAsync(City city);
    }
}
