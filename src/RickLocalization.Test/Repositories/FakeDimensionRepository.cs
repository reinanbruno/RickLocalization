using RickLocalization.Core.Entities;
using RickLocalization.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RickLocalization.Test.Repositories
{
    public class FakeDimensionRepository : IDimensionRepository
    {
        public void Dispose()
        { }

        public Task<Dimension> FindById(Guid id)
        {
            Dimension dimension = GetAll().Result.Where(x => x.Id == id).FirstOrDefault();
            return Task.FromResult(dimension);
        }

        public Task<List<Dimension>> GetAll()
        {
            List<Dimension> dimensions = new List<Dimension>();
            dimensions.Add(new Dimension { Id = Guid.Parse("4497001f-178a-495a-91f6-daabb2c473d0"), Name = "Dimensão1" });
            dimensions.Add(new Dimension { Id = Guid.Parse("3872e75e-e41b-416c-adea-f6d002a9b800"), Name = "Dimensão2" });
            dimensions.Add(new Dimension { Id = Guid.Parse("6f140d90-accb-4f19-8808-a22916a26d23"), Name = "Dimensão3" });
            dimensions.Add(new Dimension { Id = Guid.Parse("e36d2d07-c27a-4a2f-8321-6bc30764c44f"), Name = "Dimensão4" });
            dimensions.Add(new Dimension { Id = Guid.Parse("3729c480-7d4e-45a2-9f31-06e5f3ff30c5"), Name = "Dimensão5" });
            return Task.FromResult(dimensions);
        }
    }
}
