using System.Collections.Generic;

namespace RickLocalization.Application.Queries.Shared.Pagination
{
    public class PaginationViewModel<T>
    {
        public int pageCount { get; set; }
        public List<T> response { get; set; }
    }
}
