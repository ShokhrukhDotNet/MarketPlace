using System;
using System.Linq;
using System.Threading.Tasks;
using MarketPlace.Api.Models.Brands;
using Microsoft.EntityFrameworkCore;

namespace MarketPlace.Api.Brokers
{
    public partial class StorageBroker
    {
        public DbSet<Brand> Brands { get; set; }

        public async ValueTask<Brand> InsertBrandAsync(Brand brand) =>
            await InsertAsync(brand);

        public IQueryable<Brand> SelectAllBrands() => SelectAll<Brand>();

        public async ValueTask<Brand> SelectBrandByIdAsync(Guid brandId) =>
            await SelectAsync<Brand>();

        public async ValueTask<Brand> UpdateBrandAsync(Brand brand) =>
            await UpdateAsync(brand);

        public async ValueTask<Brand> DeleteBrandAsync(Brand brand) =>
            await DeleteAsync(brand);
    }
}
