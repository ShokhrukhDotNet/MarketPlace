using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using MarketPlace.Api.Brokers;
using MarketPlace.Api.Models.Brands;

namespace MarketPlace.Api.Services.Foundations.Brands
{
    public class BrandService : IBrandService
    {
        private readonly IStorageBroker storageBroker;

        public BrandService(
            IStorageBroker storageBroker) =>
                this.storageBroker = storageBroker;

        public async ValueTask<Brand> AddBrandAsync(Brand brand) =>
            await this.storageBroker.InsertBrandAsync(brand);

        public async ValueTask<Brand> RetrieveBrandByIdAsync(Guid brandId) =>
            await this.storageBroker.SelectBrandByIdAsync(brandId);

        public IQueryable<Brand> RetrieveAllBrands() =>
            this.storageBroker.SelectAllBrands();

        public async ValueTask<Brand> ModifyBrandAsync(Brand brand) =>
            await this.storageBroker.UpdateBrandAsync(brand);

        public async ValueTask<Brand> RemoveBrandByIdAsync(Guid brandId)
        {
            Brand maybeBrand =
                await this.storageBroker.SelectBrandByIdAsync(brandId);

            return await this.storageBroker.DeleteBrandAsync(maybeBrand);
        }
    }
}
