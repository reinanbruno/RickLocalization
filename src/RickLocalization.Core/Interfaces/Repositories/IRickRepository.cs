using RickLocalization.Core.Entities;
using RickLocalization.Core.Paging;
using System;
using System.Threading.Tasks;

namespace RickLocalization.Core.Interfaces.Repositories
{
    public interface IRickRepository : IDisposable
    {
        Task<PagedList<Rick>> GetAll(int pageNumber, int pageSize);
        Task<Rick> FindById(Guid id);
        Task<Rick> GetDetails(string Url);
    }
}
