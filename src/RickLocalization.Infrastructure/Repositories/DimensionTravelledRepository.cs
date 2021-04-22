using Microsoft.EntityFrameworkCore;
using RickLocalization.Core.Entities;
using RickLocalization.Core.Interfaces.Repositories;
using RickLocalization.Core.Paging;
using RickLocalization.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RickLocalization.Infrastructure.Repositories
{
    public sealed class DimensionTravelledRepository : IDimensionTravelledRepository
    {
        private readonly RickLocalizationDbContext _dbContext;

        public DimensionTravelledRepository(RickLocalizationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        #region Dispose

        public void Dispose()
        {
            Dispose(true);
        }

        ~DimensionTravelledRepository() { Dispose(false); }

        void Dispose(bool disposing)
        {
            if (disposing)
            {
                GC.SuppressFinalize(this);
            }
        }

        #endregion

        public async Task<DimensionTravelled> FindLastTravel(Guid idRick)
        {
            return await _dbContext.DimensionsTravelled
                                   .Where(x => x.IdRick == idRick)
                                   .OrderByDescending(x => x.RegistrationDate)
                                   .FirstOrDefaultAsync();
        }

        public Task<PagedList<DimensionTravelled>> GetAllTravels(string url, int pageNumber, int pageSize)
        {
            IQueryable<DimensionTravelled> query = _dbContext.DimensionsTravelled
                                                             .Include(x => x.DimensionBefore)
                                                             .Include(x => x.DimensionCurrent)
                                                             .Where(x => x.Rick.Url == url)
                                                             .OrderBy(x => x.RegistrationDate);

            return Task.FromResult(PagedList<DimensionTravelled>.GetPagedList(query, pageNumber, pageSize));
        }

        public async Task Insert(DimensionTravelled dimensionTravelled)
        {
            await _dbContext.AddAsync(dimensionTravelled);
        }

    }
}
