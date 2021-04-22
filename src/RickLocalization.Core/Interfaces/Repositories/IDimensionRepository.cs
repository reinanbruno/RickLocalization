using RickLocalization.Core.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RickLocalization.Core.Interfaces.Repositories
{
    public interface IDimensionRepository : IDisposable
    {
        Task<List<Dimension>> GetAll();
        Task<Dimension> FindById(Guid id);
    }
}
