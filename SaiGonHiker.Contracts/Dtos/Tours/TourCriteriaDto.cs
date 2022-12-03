using System;
using SaiGonHiker.Contracts;

namespace SaiGonHiker.Contracts.Dtos.Tours
{
    public class TourCriteriaDto : BaseQueryCriteria
    {
        public string Region { get; set; } 
    }
}