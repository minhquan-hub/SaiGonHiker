using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SaiGonHiker.Contracts;
using SaiGonHiker.Contracts.Constants;
using SaiGonHiker.Contracts.Dtos.Tours;
using SaiGonHiker.Business.Interfaces;

namespace SaiGonHiker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TourController : ControllerBase {

        public readonly ITourService _tourService;

        public TourController(ITourService tourService) 
        {
            _tourService = tourService;
        }

        [HttpGet]
        public async Task<ActionResult<TourDto>> GetTours([FromQuery] TourCriteriaDto tourCriteriaDto, CancellationToken cancellationToken)
        {
            if (tourCriteriaDto == null)
            {
                throw new NotFoundException("tourCriteriaDto is null");
            }
            
            return Ok(await _tourService.GetTours(tourCriteriaDto, cancellationToken));
        }
    }
}