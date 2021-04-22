using MediatR;
using RickLocalization.Application.Queries.Shared.Pagination;

namespace RickLocalization.Application.Queries.Ricks.GetAll
{
    public class GetAllRickInputModel : IRequest<PaginationViewModel<GetAllRickViewModel>>
    {
        public int pageNumber { get; set; }
        public int pageSize { get; set; }
    }
}
