using MediatR;
using RickLocalization.Application.Commands.Contracts;
using System;

namespace RickLocalization.Application.Commands.DimensionsTravelled.Add
{
    public class AddDimensionTravelledInputModel : IRequest<ICommandResult<Guid>>
    {
        public Guid idRick { get; set; }
        public Guid idDimension { get; set; }

    }
}
