using RickLocalization.Core.Interfaces.UoW;
using RickLocalization.Infrastructure.Context;
using System;
using System.Threading.Tasks;

namespace RickLocalization.Infrastructure.Repositories
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private readonly RickLocalizationDbContext _context;

        public UnitOfWork(RickLocalizationDbContext context)
        {
            _context = context;
        }

        #region Dispose

        public void Dispose()
        {
            Dispose(true);
        }

        ~UnitOfWork() { Dispose(false); }

        void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
                GC.SuppressFinalize(this);
            }
        }

        #endregion

        public async Task<bool> Commit()
        {
            return await _context.SaveChangesAsync() > 0;
        }

    }
}
