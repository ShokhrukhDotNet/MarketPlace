using System;
using System.Linq;
using System.Threading.Tasks;
using MarketPlace.Api.Brokers;
using MarketPlace.Api.Models.Cars;

namespace MarketPlace.Api.Services.Foundations.Cars
{
    public class CarService : ICarService
    {
        private readonly IStorageBroker storageBroker;

        public CarService(
            IStorageBroker storageBroker) =>
                this.storageBroker = storageBroker;

        public async ValueTask<Car> AddCarAsync(Car car) =>
            await this.storageBroker.InsertCarAsync(car);

        public async ValueTask<Car> RetrieveCarByIdAsync(Guid carId) =>
            await this.storageBroker.SelectCarByIdAsync(carId);

        public IQueryable<Car> RetrieveAllCars() =>
            this.storageBroker.SelectAllCars();

        public async ValueTask<Car> ModifyCarAsync(Car car) =>
            await this.storageBroker.UpdateCarAsync(car);

        public async ValueTask<Car> RemoveCarByIdAsync(Guid carId)
        {
            Car maybeCar =
                await this.storageBroker.SelectCarByIdAsync(carId);

            return await this.storageBroker.DeleteCarAsync(maybeCar);
        }
    }
}
