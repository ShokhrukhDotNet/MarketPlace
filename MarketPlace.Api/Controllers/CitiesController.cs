using System;
using System.Linq;
using System.Threading.Tasks;
using MarketPlace.Api.Models.Cities;
using MarketPlace.Api.Services.Foundations.Cities;
using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace MarketPlace.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CitiesController : RESTFulController
    {
        private readonly ICityService cityService;

        public CitiesController(ICityService cityService) =>
            this.cityService = cityService;

        [HttpPost]
        public async ValueTask<ActionResult<City>> PostCityAsync(City city)
        {
            City postedCity = await this.cityService.AddCityAsync(city);

            return Created(postedCity);
        }

        [HttpGet("ById")]
        public async ValueTask<ActionResult<City>> GetCityByIdAsync(Guid cityId) =>
            await this.cityService.RetrieveCityByIdAsync(cityId);

        [HttpGet("All")]
        public ActionResult<IQueryable<City>> GetAllCitys()
        {
            IQueryable<City> allCities = this.cityService.RetrieveAllCities();

            return Ok(allCities);
        }

        [HttpPut]
        public async ValueTask<ActionResult<City>> PutCityAsync(City city)
        {
            City modifyCity =
                    await this.cityService.ModifyCityAsync(city);

            return Ok(modifyCity);
        }

        [HttpDelete]
        public async ValueTask<ActionResult<City>> DeleteCityAsync(Guid cityId)
        {
            City deleteCity = await this.cityService.RemoveCityByIdAsync(cityId);

            return Ok(deleteCity);
        }
    }
}
