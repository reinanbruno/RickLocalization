using MediatR;
using RickLocalization.Application.Queries.Shared.Pagination;
using System;

namespace RickLocalization.Application.Queries.DimensionsTravelled.GetTravels
{
    public class GetTravelsInputModel : IRequest<PaginationViewModel<GetTravelsViewModel>>
    {
        public String urlRick { get; set; }
        public int pageNumber { get; set; }
        public int pageSize { get; set; }
    }
}
