using AutoMapper;
using MediatR;
using RickLocalization.Application.Queries.Shared.Pagination;
using RickLocalization.Core.Entities;
using RickLocalization.Core.Interfaces.Repositories;
using RickLocalization.Core.Paging;
using System.Threading;
using System.Threading.Tasks;

namespace RickLocalization.Application.Queries.Ricks.GetAll
{
    public sealed class GetAllRickQueryHandler : IRequestHandler<GetAllRickInputModel, PaginationViewModel<GetAllRickViewModel>>
    {
        private readonly IRickRepository _repositoryRick;
        private readonly IMapper _mapper;

        public GetAllRickQueryHandler(IRickRepository repositoryRick, IMapper mapper)
        {
            _repositoryRick = repositoryRick;
            _mapper = mapper;
        }

        public async Task<PaginationViewModel<GetAllRickViewModel>> Handle(GetAllRickInputModel request, CancellationToken cancellationToken)
        {
            return _mapper.Map<PaginationViewModel<GetAllRickViewModel>>(await _repositoryRick.GetAll(request.pageNumber, request.pageSize));
        }
    }
}
