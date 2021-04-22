using AutoMapper;
using MediatR;
using RickLocalization.Core.Interfaces.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace RickLocalization.Application.Queries.Ricks.GetDetails
{
    public class GetDetailsRickQueryHandler : IRequestHandler<GetDetailsRickInputModel, GetDetailsRickViewModel>
    {
        private readonly IRickRepository _repositoryRick;
        private readonly IMapper _mapper;

        public GetDetailsRickQueryHandler(IRickRepository repositoryRick, IMapper mapper)
        {
            _repositoryRick = repositoryRick;
            _mapper = mapper;
        }

        public async Task<GetDetailsRickViewModel> Handle(GetDetailsRickInputModel request, CancellationToken cancellationToken)
        {
            return _mapper.Map<GetDetailsRickViewModel>(await _repositoryRick.GetDetails(request.url));
        }
    }
}