using System.Threading.Tasks;
using System.Threading;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using System;
using System.Security.Claims;
using System.Text;
using SaiGonHiker.Business.Interfaces;
using SaiGonHiker.Business;
using SaiGonHiker.Contracts;
using SaiGonHiker.DataAccessor.Entities;
using SaiGonHiker.Contracts.Dtos.Tours;

namespace SaiGonHiker.Business.Services
{
    public class TourService : ITourService
    {
        private readonly IBaseRepository<Tour> _tourRepository;
        private readonly IMapper _mapper;

        public TourService(IBaseRepository<Tour> tourRepository, IMapper mapper) 
        {
            _tourRepository = tourRepository;
            _mapper = mapper;
        } 

        public async Task<ActionResult<PagedResponseModel<TourDto>>> GetTours(TourCriteriaDto tourCriteriaDto, CancellationToken cancellationToken)
        {
            IQueryable<Tour> tours  = _tourRepository.Entities.Where(tour => (tour.Region == tourCriteriaDto.Region));
            var pageTour = await tours.PaginateAsync(tourCriteriaDto, cancellationToken);
            var tourDto = _mapper.Map<IEnumerable<TourDto>>(pageTour.Items);
            return new PagedResponseModel<TourDto> {
                CurrentPage = pageTour.CurrentPage,
                TotalItems = pageTour.TotalItems,
                TotalPages = pageTour.TotalPages,
                Search = tourCriteriaDto.Search,
                SortOrder = tourCriteriaDto.SortOrder,
                SortColumn = tourCriteriaDto.SortColumn,
                Limit = tourCriteriaDto.Limit,
                Page = tourCriteriaDto.Page,
                Items = tourDto
            };
        }
    }
}