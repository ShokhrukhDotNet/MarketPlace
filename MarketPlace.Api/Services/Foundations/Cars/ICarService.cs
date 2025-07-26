using System;
using System.Linq;
using System.Threading.Tasks;
using MarketPlace.Api.Models.Cars;

namespace MarketPlace.Api.Services.Foundations.Cars
{
    public interface ICarService
    {
        ValueTask<Car> AddCarAsync(Car car);
        IQueryable<Car> RetrieveAllCars();
        ValueTask<Car> RetrieveCarByIdAsync(Guid carId);
        ValueTask<Car> RemoveCarByIdAsync(Guid locationId);
        ValueTask<Car> ModifyCarAsync(Car car);
    }
}
