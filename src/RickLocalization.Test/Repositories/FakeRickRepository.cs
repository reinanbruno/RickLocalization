using RickLocalization.Core.Entities;
using RickLocalization.Core.Interfaces.Repositories;
using RickLocalization.Core.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RickLocalization.Test.Repositories
{
    public class FakeRickRepository : IRickRepository
    {
        public void Dispose()
        { }

        public Task<Rick> FindById(Guid id)
        {
            Rick rick = GetAll(0, 0).Result.Response.Where(x => x.Id == id).FirstOrDefault();
            return Task.FromResult(rick);
        }

        public Task<PagedList<Rick>> GetAll(int pageIndex, int pageSize)
        {
            List<Rick> ricks = new List<Rick>();
            ricks.Add(new Rick
            {
                Id = Guid.Parse("c8591d79-25a0-4549-bd33-da688141a2d4"),
                IdDimensionOrigin = Guid.Parse("4497001f-178a-495a-91f6-daabb2c473d0"),
                IdMorty = Guid.Parse("fa138bf4-4312-4328-ac47-decb57ecf82a"),
                Url = "rick1",
                Name = "Rick1"
            });
            ricks.Add(new Rick
            {
                Id = Guid.Parse("6423bf03-7f20-4458-9a3f-55b21910b97b"),
                IdDimensionOrigin = Guid.Parse("6f140d90-accb-4f19-8808-a22916a26d23"),
                IdMorty = Guid.Parse("7d6bb2ac-c9cb-46e3-842c-1a353da348c8"),
                Url = "rick2",
                Name = "Rick2"
            });

            IQueryable<Rick> query = ricks.AsQueryable();
            return Task.FromResult(PagedList<Rick>.GetPagedList(query, 0, 10));
        }

        public Task<Rick> GetDetails(string Url)
        {
            Rick rick = GetAll(0, 0).Result.Response.Where(x => x.Url == Url).FirstOrDefault();
            return Task.FromResult(rick);
        }
    }
}
