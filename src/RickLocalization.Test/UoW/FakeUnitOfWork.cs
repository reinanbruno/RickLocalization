using RickLocalization.Core.Interfaces.UoW;
using System.Threading.Tasks;

namespace RickLocalization.Test.UoW
{
    public class FakeUnitOfWork : IUnitOfWork
    {
        public Task<bool> Commit()
        {
            return Task.FromResult(true);
        }

        public void Dispose()
        {
        }
    }
}
