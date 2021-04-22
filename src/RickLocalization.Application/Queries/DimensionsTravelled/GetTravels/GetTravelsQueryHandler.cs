using AutoMapper;
using MediatR;
using RickLocalization.Application.Queries.Shared.Pagination;
using RickLocalization.Core.Interfaces.Repositories;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace RickLocalization.Application.Queries.DimensionsTravelled.GetTravels
{
    public class GetTravelsQueryHandler : IRequestHandler<GetTravelsInputModel, PaginationViewModel<GetTravelsViewModel>>
    {
        private readonly IDimensionTravelledRepository _dimensionTravelledRepository;
        private readonly IMapper _mapper;

        public GetTravelsQueryHandler(IDimensionTravelledRepository dimensionTravelledRepository, IMapper mapper)
        {
            _dimensionTravelledRepository = dimensionTravelledRepository;
            _mapper = mapper;
        }

        public async Task<PaginationViewModel<GetTravelsViewModel>> Handle(GetTravelsInputModel request, CancellationToken cancellationToken)
        {
            return _mapper.Map<PaginationViewModel<GetTravelsViewModel>>(await _dimensionTravelledRepository.GetAllTravels(request.urlRick, 
                                                                                                                           request.pageNumber, 
                                                                                                                           request.pageSize));
        }
    }
}
