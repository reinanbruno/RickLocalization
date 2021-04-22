using MediatR;
using System;
using System.Collections.Generic;

namespace RickLocalization.Application.Queries.Ricks.GetDetails
{
    public class GetDetailsRickInputModel : IRequest<GetDetailsRickViewModel>
    {
        public String url { get; set; }
    }
}
