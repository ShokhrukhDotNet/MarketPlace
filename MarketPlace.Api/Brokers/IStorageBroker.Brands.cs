using System;
using System.Linq;
using System.Threading.Tasks;
using MarketPlace.Api.Models.Brands;

namespace MarketPlace.Api.Brokers
{
    public partial interface IStorageBroker
    {
        ValueTask<Brand> InsertBrandAsync(Brand brand);
        IQueryable<Brand> SelectAllBrands();
        ValueTask<Brand> SelectBrandByIdAsync(Guid brandId);
        ValueTask<Brand> UpdateBrandAsync(Brand brand);
        ValueTask<Brand> DeleteBrandAsync(Brand brand);
    }
}
