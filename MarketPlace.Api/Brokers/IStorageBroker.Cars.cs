using System;
using System.Linq;
using System.Threading.Tasks;
using MarketPlace.Api.Models.Cars;

namespace MarketPlace.Api.Brokers
{
    public partial interface IStorageBroker
    {
        ValueTask<Car> InsertCarAsync(Car car);
        IQueryable<Car> SelectAllCars();
        ValueTask<Car> SelectCarByIdAsync(Guid carId);
        ValueTask<Car> UpdateCarAsync(Car car);
        ValueTask<Car> DeleteCarAsync(Car car);
    }
}
