using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickLocalization.Core.Interfaces.UoW
{
    public interface IUnitOfWork : IDisposable
    {
        Task<bool> Commit();
    }
}
