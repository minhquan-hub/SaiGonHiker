using System;
using SaiGonHiker.Contracts;

namespace SaiGonHiker.Contracts.Dtos.Tours
{
    public class TourDto : BaseQueryCriteria
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public string Address { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }

        public DateTime DateOfDeparture { get; set; }

        public DateTime DateOfArrival { get; set; }

        public string Image { get; set; }
    }
}