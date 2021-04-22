using Microsoft.EntityFrameworkCore;
using RickLocalization.Core.Entities;
using RickLocalization.Core.Interfaces.Repositories;
using RickLocalization.Core.Paging;
using RickLocalization.Infrastructure.Context;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace RickLocalization.Infrastructure.Repositories
{
    public sealed class RickRepository : IRickRepository
    {
        private readonly RickLocalizationDbContext _dbContext;

        public RickRepository(RickLocalizationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        #region Dispose

        public void Dispose()
        {
            Dispose(true);
        }

        ~RickRepository() { Dispose(false); }

        void Dispose(bool disposing)
        {
            if (disposing)
            {
                GC.SuppressFinalize(this);
            }
        }

        #endregion

        public async Task<Rick> FindById(Guid id)
        {
            return await _dbContext.Ricks
                                   .Where(x => x.Id == id)
                                   .FirstOrDefaultAsync();
        }

        public Task<PagedList<Rick>> GetAll(int pageNumber, int pageSize)
        {
            IQueryable<Rick> query =  _dbContext.Ricks
                                                .Include(x => x.Morty)
                                                .OrderBy(x => x.RegistrationDate);

            return Task.FromResult(PagedList<Rick>.GetPagedList(query, pageNumber, pageSize));
        }

        public async Task<Rick> GetDetails(string url)
        {
            return await _dbContext.Ricks
                                   .Include(x => x.DimensionsTravelled.OrderBy(x => x.RegistrationDate))
                                   .ThenInclude(x => x.DimensionCurrent)
                                   .Where(x => x.Url == url)
                                   .FirstOrDefaultAsync();
        }
    }
}
