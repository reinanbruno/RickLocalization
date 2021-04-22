using RickLocalization.Core.Entities;
using RickLocalization.Core.Paging;
using System;
using System.Threading.Tasks;

namespace RickLocalization.Core.Interfaces.Repositories
{
    public interface IDimensionTravelledRepository : IDisposable
    {
        Task<PagedList<DimensionTravelled>> GetAllTravels(string url, int pageNumber, int pageSize);
        Task<DimensionTravelled> FindLastTravel(Guid idRick);
        Task Insert(DimensionTravelled dimensionTravelled);
    }
}
