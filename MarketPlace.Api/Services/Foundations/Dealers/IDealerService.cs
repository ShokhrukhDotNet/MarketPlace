using System;
using System.Linq;
using System.Threading.Tasks;
using MarketPlace.Api.Models.Dealers;

namespace MarketPlace.Api.Services.Foundations.Dealers
{
    public interface IDealerService
    {
        ValueTask<Dealer> AddDealerAsync(Dealer dealer);
        IQueryable<Dealer> RetrieveAllDealers();
        ValueTask<Dealer> RetrieveDealerByIdAsync(Guid dealerId);
        ValueTask<Dealer> RemoveDealerByIdAsync(Guid locationId);
        ValueTask<Dealer> ModifyDealerAsync(Dealer dealer);
    }
}
