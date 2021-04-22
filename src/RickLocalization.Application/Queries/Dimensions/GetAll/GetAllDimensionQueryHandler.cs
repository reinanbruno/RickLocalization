using AutoMapper;
using MediatR;
using RickLocalization.Core.Interfaces.Repositories;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace RickLocalization.Application.Queries.Dimensions.GetAll
{
    class GetAllDimensionQueryHandler : IRequestHandler<GetAllDimensionQuery, List<GetAllDimensionViewModel>>
    {
        private readonly IDimensionRepository _repositoryDimension;
        private readonly IMapper _mapper;

        public GetAllDimensionQueryHandler(IDimensionRepository repositoryDimension, IMapper mapper)
        {
            _repositoryDimension = repositoryDimension;
            _mapper = mapper;
        }

        public async Task<List<GetAllDimensionViewModel>> Handle(GetAllDimensionQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<List<GetAllDimensionViewModel>>(await _repositoryDimension.GetAll());
        }
    }
}
