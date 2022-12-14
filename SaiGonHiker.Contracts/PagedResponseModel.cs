using System.Collections.Generic;

namespace SaiGonHiker.Contracts
{
    public class PagedResponseModel<TModel> : BaseQueryCriteria
    {
        public int CurrentPage { get; set; }

        public int TotalItems { get; set; }

        public int TotalPages { get; set; }

        public IEnumerable<TModel> Items { get; set; }
    }
}