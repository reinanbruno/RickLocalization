using System.Collections.Generic;
using System.Linq;

namespace RickLocalization.Core.Paging
{
    public sealed class PagedList<T>
    {
        public long PageCount { get; private set; }
        public List<T> Response { get; private set; }

        private PagedList(List<T> result, long pageCount)
        {
            PageCount = pageCount;
            Response = result;
        }

        public static PagedList<T> GetPagedList(IQueryable<T> query, int pageNumber, int pageSize)
        {
            long count = query.Count();
            List<T> items = query.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            return new PagedList<T>(items, count);
        }
    }
}
