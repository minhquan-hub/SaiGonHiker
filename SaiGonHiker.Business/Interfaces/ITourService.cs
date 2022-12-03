using System.Threading.Tasks;
using System.Threading;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SaiGonHiker.Contracts.Dtos.Tours;
using SaiGonHiker.Business;
using SaiGonHiker.Contracts;

namespace SaiGonHiker.Business.Interfaces
{
    public interface ITourService
    {
        public Task<ActionResult<PagedResponseModel<TourDto>>> GetTours(TourCriteriaDto search, CancellationToken cancellationToken);
    }
}