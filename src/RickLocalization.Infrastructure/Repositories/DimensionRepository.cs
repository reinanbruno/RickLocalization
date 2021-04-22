using Microsoft.EntityFrameworkCore;
using RickLocalization.Core.Entities;
using RickLocalization.Core.Interfaces.Repositories;
using RickLocalization.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RickLocalization.Infrastructure.Repositories
{
    public sealed class DimensionRepository : IDimensionRepository
    {
        private readonly RickLocalizationDbContext _dbContext;

        public DimensionRepository(RickLocalizationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        #region Dispose

        public void Dispose()
        {
            Dispose(true);
        }

        ~DimensionRepository() { Dispose(false); }

        void Dispose(bool disposing)
        {
            if (disposing)
            {
                GC.SuppressFinalize(this);
            }
        }

        #endregion

        public async Task<Dimension> FindById(Guid id)
        {
            return await _dbContext.Dimensions
                                   .Where(x => x.Id == id)
                                   .FirstOrDefaultAsync();
        }

        public async Task<List<Dimension>> GetAll()
        {
            return await _dbContext.Dimensions
                                   .OrderBy(x => x.Name)
                                   .ToListAsync();
        }
    }
}
