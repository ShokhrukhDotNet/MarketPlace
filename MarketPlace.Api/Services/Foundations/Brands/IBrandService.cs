using System;
using System.Linq;
using System.Threading.Tasks;
using MarketPlace.Api.Models.Brands;

namespace MarketPlace.Api.Services.Foundations.Brands
{
    public interface IBrandService
    {
        ValueTask<Brand> AddBrandAsync(Brand brand);
        IQueryable<Brand> RetrieveAllBrands();
        ValueTask<Brand> RetrieveBrandByIdAsync(Guid brandId);
        ValueTask<Brand> RemoveBrandByIdAsync(Guid locationId);
        ValueTask<Brand> ModifyBrandAsync(Brand brand);
    }
}
