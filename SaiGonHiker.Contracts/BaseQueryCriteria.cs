using System.Collections.Generic;
using SaiGonHiker.Contracts.Constants.Enum;

namespace SaiGonHiker.Contracts
{
    public class BaseQueryCriteria
    {
        public string Search { get; set; }
        public SortOrderEnum SortOrder { get; set; }
        public string SortColumn { get; set; }
        public int Limit { get; set; } = 6;
        public int Page { get; set; } = 1;
    }
}