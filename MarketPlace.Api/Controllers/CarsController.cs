using System;
using System.Linq;
using System.Threading.Tasks;
using MarketPlace.Api.Models.Cars;
using MarketPlace.Api.Services.Foundations.Cars;
using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace MarketPlace.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarsController : RESTFulController
    {
        private readonly ICarService carService;

        public CarsController(ICarService carService) =>
            this.carService = carService;

        [HttpPost]
        public async ValueTask<ActionResult<Car>> PostCarAsync(Car car)
        {
            Car postedCar = await this.carService.AddCarAsync(car);

            return Created(postedCar);
        }

        [HttpGet("ById")]
        public async ValueTask<ActionResult<Car>> GetCarByIdAsync(Guid carId) =>
            await this.carService.RetrieveCarByIdAsync(carId);

        [HttpGet("All")]
        public ActionResult<IQueryable<Car>> GetAllCars()
        {
            IQueryable<Car> allCars = this.carService.RetrieveAllCars();

            return Ok(allCars);
        }

        [HttpPut]
        public async ValueTask<ActionResult<Car>> PutCarAsync(Car car)
        {
            Car modifyCar =
                    await this.carService.ModifyCarAsync(car);

            return Ok(modifyCar);
        }

        [HttpDelete]
        public async ValueTask<ActionResult<Car>> DeleteCarAsync(Guid carId)
        {
            Car deleteCar = await this.carService.RemoveCarByIdAsync(carId);

            return Ok(deleteCar);
        }
    }
}
