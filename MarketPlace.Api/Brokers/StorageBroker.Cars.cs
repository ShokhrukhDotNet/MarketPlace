using System;
using System.Linq;
using System.Threading.Tasks;
using MarketPlace.Api.Models.Cars;
using Microsoft.EntityFrameworkCore;

namespace MarketPlace.Api.Brokers
{
    public partial class StorageBroker
    {
        public DbSet<Car> Cars { get; set; }

        public async ValueTask<Car> InsertCarAsync(Car car) =>
            await InsertAsync(car);

        public IQueryable<Car> SelectAllCars() => SelectAll<Car>();

        public async ValueTask<Car> SelectCarByIdAsync(Guid carId) =>
            await SelectAsync<Car>();

        public async ValueTask<Car> UpdateCarAsync(Car car) =>
            await UpdateAsync(car);

        public async ValueTask<Car> DeleteCarAsync(Car car) =>
            await DeleteAsync(car);
    }
}
