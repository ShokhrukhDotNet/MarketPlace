using System;
using System.Linq;
using System.Threading.Tasks;
using MarketPlace.Api.Brokers;
using MarketPlace.Api.Models.Dealers;

namespace MarketPlace.Api.Services.Foundations.Dealers
{
    public class DealerService : IDealerService
    {
        private readonly IStorageBroker storageBroker;

        public DealerService(
            IStorageBroker storageBroker) =>
                this.storageBroker = storageBroker;

        public async ValueTask<Dealer> AddDealerAsync(Dealer dealer) =>
            await this.storageBroker.InsertDealerAsync(dealer);

        public async ValueTask<Dealer> RetrieveDealerByIdAsync(Guid dealerId) =>
            await this.storageBroker.SelectDealerByIdAsync(dealerId);

        public IQueryable<Dealer> RetrieveAllDealers() =>
            this.storageBroker.SelectAllDealers();

        public async ValueTask<Dealer> ModifyDealerAsync(Dealer dealer) =>
            await this.storageBroker.UpdateDealerAsync(dealer);

        public async ValueTask<Dealer> RemoveDealerByIdAsync(Guid dealerId)
        {
            Dealer maybeDealer =
                await this.storageBroker.SelectDealerByIdAsync(dealerId);

            return await this.storageBroker.DeleteDealerAsync(maybeDealer);
        }
    }
}
