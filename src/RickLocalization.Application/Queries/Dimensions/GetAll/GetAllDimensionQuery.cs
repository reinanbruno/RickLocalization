using MediatR;
using System.Collections.Generic;

namespace RickLocalization.Application.Queries.Dimensions.GetAll
{
    public class GetAllDimensionQuery : IRequest<List<GetAllDimensionViewModel>>
    {
    }
}
