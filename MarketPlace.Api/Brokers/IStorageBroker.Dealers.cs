using System;
using System.Linq;
using System.Threading.Tasks;
using MarketPlace.Api.Models.Dealers;

namespace MarketPlace.Api.Brokers
{
    public partial interface IStorageBroker
    {
        ValueTask<Dealer> InsertDealerAsync(Dealer dealer);
        IQueryable<Dealer> SelectAllDealers();
        ValueTask<Dealer> SelectDealerByIdAsync(Guid dealerId);
        ValueTask<Dealer> UpdateDealerAsync(Dealer dealer);
        ValueTask<Dealer> DeleteDealerAsync(Dealer dealer);
    }
}
