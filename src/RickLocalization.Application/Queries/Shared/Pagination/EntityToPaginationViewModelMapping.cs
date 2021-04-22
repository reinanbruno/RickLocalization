using AutoMapper;
using RickLocalization.Core.Paging;

namespace RickLocalization.Application.Queries.Shared.Pagination
{
    public class EntityToPaginationViewModelMapping : Profile
    {
        public EntityToPaginationViewModelMapping()
        {
            CreateMap(typeof(PagedList<>), typeof(PaginationViewModel<>));
        }
    }
}
