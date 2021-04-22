using RickLocalization.Core.Entities;
using RickLocalization.Core.Interfaces.Repositories;
using RickLocalization.Core.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RickLocalization.Test.Repositories
{
    public class FakeDimensionTravelledRepository : IDimensionTravelledRepository
    {
        public void Dispose()
        { }

        private List<DimensionTravelled> getAllDataFakeList(Func<DimensionTravelled, bool> func)
        {
            List<DimensionTravelled> dimensionTravelleds = new List<DimensionTravelled>();
            dimensionTravelleds.Add(new DimensionTravelled
            {
                Id = new Guid("e27999ce-a6b7-496f-97c2-a173e30501d8"),
                IdDimensionCurrent = Guid.Parse("6f140d90-accb-4f19-8808-a22916a26d23"),
                IdRick = Guid.Parse("c8591d79-25a0-4549-bd33-da688141a2d4"),
                RegistrationDate = DateTime.Now.AddDays(-1),
                Rick = new Rick
                {
                    Url = "rick-1"
                }
            });
            dimensionTravelleds.Add(new DimensionTravelled
            {
                Id = new Guid("61286f10-2445-47ea-84d3-15574eda3ad2"),
                IdDimensionCurrent = Guid.Parse("4497001f-178a-495a-91f6-daabb2c473d0"),
                IdRick = Guid.Parse("c8591d79-25a0-4549-bd33-da688141a2d4"),
                RegistrationDate = DateTime.Now,
                Rick = new Rick
                {
                    Url = "rick-1"
                }
            });
            dimensionTravelleds.Add(new DimensionTravelled
            {
                Id = new Guid("d8f22c92-cf97-4d04-aea2-1870e12c5497"),
                IdDimensionCurrent = Guid.Parse("4497001f-178a-495a-91f6-daabb2c473d0"),
                IdRick = Guid.Parse("6423bf03-7f20-4458-9a3f-55b21910b97b"),
                RegistrationDate = DateTime.Now,
                Rick = new Rick
                {
                    Url = "rick-2"
                }
            });

            return dimensionTravelleds.Where(func).ToList();
        }


        public Task<DimensionTravelled> FindLastTravel(Guid idRick)
        {
            DimensionTravelled dimensionTravelled = getAllDataFakeList(a => a.IdRick == idRick).LastOrDefault();
            return Task.FromResult(dimensionTravelled);
        }

        public Task<PagedList<DimensionTravelled>> GetAllTravels(string urlRick, int pageNumber, int pageSize)
        {

            IQueryable<DimensionTravelled> query = getAllDataFakeList(a => a.Rick.Url == urlRick)
                                                                    .OrderBy(x => x.RegistrationDate)
                                                                    .AsQueryable();

            return Task.FromResult(PagedList<DimensionTravelled>.GetPagedList(query, 0, 10));
        }

        public Task Insert(DimensionTravelled dimensionTravelled)
        {
            return Task.CompletedTask;
        }

    }
}
