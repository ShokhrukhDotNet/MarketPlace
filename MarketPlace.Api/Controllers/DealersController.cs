using System;
using System.Linq;
using System.Threading.Tasks;
using MarketPlace.Api.Models.Dealers;
using MarketPlace.Api.Services.Foundations.Dealers;
using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace MarketPlace.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DealersController : RESTFulController
    {
        private readonly IDealerService dealerService;

        public DealersController(IDealerService dealerService) =>
            this.dealerService = dealerService;

        [HttpPost]
        public async ValueTask<ActionResult<Dealer>> PostDealerAsync(Dealer dealer)
        {
            Dealer postedDealer = await this.dealerService.AddDealerAsync(dealer);

            return Created(postedDealer);
        }

        [HttpGet("ById")]
        public async ValueTask<ActionResult<Dealer>> GetDealerByIdAsync(Guid dealerId) =>
            await this.dealerService.RetrieveDealerByIdAsync(dealerId);

        [HttpGet("All")]
        public ActionResult<IQueryable<Dealer>> GetAllDealers()
        {
            IQueryable<Dealer> allDealers = this.dealerService.RetrieveAllDealers();

            return Ok(allDealers);
        }

        [HttpPut]
        public async ValueTask<ActionResult<Dealer>> PutDealerAsync(Dealer dealer)
        {
            Dealer modifyDealer =
                    await this.dealerService.ModifyDealerAsync(dealer);

            return Ok(modifyDealer);
        }

        [HttpDelete]
        public async ValueTask<ActionResult<Dealer>> DeleteDealerAsync(Guid dealerId)
        {
            Dealer deleteDealer = await this.dealerService.RemoveDealerByIdAsync(dealerId);

            return Ok(deleteDealer);
        }
    }
}
