using System;
using System.Linq;
using System.Threading.Tasks;
using MarketPlace.Api.Models.Dealers;
using Microsoft.EntityFrameworkCore;

namespace MarketPlace.Api.Brokers
{
    public partial class StorageBroker
    {
        public DbSet<Dealer> Dealers { get; set; }

        public async ValueTask<Dealer> InsertDealerAsync(Dealer dealer) =>
            await InsertAsync(dealer);

        public IQueryable<Dealer> SelectAllDealers() => SelectAll<Dealer>();

        public async ValueTask<Dealer> SelectDealerByIdAsync(Guid dealerId) =>
            await SelectAsync<Dealer>();

        public async ValueTask<Dealer> UpdateDealerAsync(Dealer dealer) =>
            await UpdateAsync(dealer);

        public async ValueTask<Dealer> DeleteDealerAsync(Dealer dealer) =>
            await DeleteAsync(dealer);
    }
}
