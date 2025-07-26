using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using MarketPlace.Api.Models.Brands;
using MarketPlace.Api.Services.Foundations.Brands;
using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace MarketPlace.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BrandsController : RESTFulController
    {
        private readonly IBrandService brandService;

        public BrandsController(IBrandService brandService) =>
            this.brandService = brandService;

        [HttpPost]
        public async ValueTask<ActionResult<Brand>> PostBrandAsync(Brand brand)
        {
            Brand postedBrand = await this.brandService.AddBrandAsync(brand);

            return Created(postedBrand);
        }

        [HttpGet("ById")]
        public async ValueTask<ActionResult<Brand>> GetBrandByIdAsync(Guid brandId) =>
            await this.brandService.RetrieveBrandByIdAsync(brandId);

        [HttpGet("All")]
        public ActionResult<IQueryable<Brand>> GetAllBrands()
        {
            IQueryable<Brand> allBrands = this.brandService.RetrieveAllBrands();

            return Ok(allBrands);
        }

        [HttpPut]
        public async ValueTask<ActionResult<Brand>> PutBrandAsync(Brand brand)
        {
            Brand modifyBrand =
                    await this.brandService.ModifyBrandAsync(brand);

            return Ok(modifyBrand);
        }

        [HttpDelete]
        public async ValueTask<ActionResult<Brand>> DeleteBrandAsync(Guid brandId)
        {
            Brand deleteBrand = await this.brandService.RemoveBrandByIdAsync(brandId);

            return Ok(deleteBrand);
        }
    }
}
