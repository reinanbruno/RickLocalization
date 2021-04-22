using AutoMapper;
using MediatR;
using RickLocalization.Application.Commands.Contracts;
using RickLocalization.Core.Entities;
using RickLocalization.Core.Interfaces.Repositories;
using RickLocalization.Core.Interfaces.UoW;
using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace RickLocalization.Application.Commands.DimensionsTravelled.Add
{
    public class AddDimensionTravelledCommandHandler : IRequestHandler<AddDimensionTravelledInputModel, ICommandResult<Guid>>
    {
        private readonly IDimensionTravelledRepository _repositoryDimensionTravelled;
        private readonly IRickRepository _repositoryRick;
        private readonly IDimensionRepository _repositoryDimension;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public AddDimensionTravelledCommandHandler(IDimensionTravelledRepository repositoryDimensionTravelled, 
                                                   IRickRepository repositoryRick, 
                                                   IDimensionRepository repositoryDimension, 
                                                   IMapper mapper,
                                                   IUnitOfWork unitOfWork)
        {
            _repositoryDimensionTravelled = repositoryDimensionTravelled;
            _repositoryRick = repositoryRick;
            _repositoryDimension = repositoryDimension;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<ICommandResult<Guid>> Handle(AddDimensionTravelledInputModel request, CancellationToken cancellationToken)
        {
            if (await _repositoryRick.FindById(request.idRick) == null)
            {
                return new CommandResult<Guid>
                {
                    message = "Ops! Esse rick não existe.",
                    success = false,
                    httpStatusCode = HttpStatusCode.NotFound
                };
            }

            if (await _repositoryDimension.FindById(request.idDimension) == null)
            {
                return new CommandResult<Guid>
                {
                    message = "Ops! Essa dimensão não existe.",
                    success = false,
                    httpStatusCode = HttpStatusCode.NotFound
                };
            }

            DimensionTravelled lastDimensionTravelled = await _repositoryDimensionTravelled.FindLastTravel(request.idRick);

            if (lastDimensionTravelled != null && lastDimensionTravelled.IdDimensionCurrent == request.idDimension)
            {
                return new CommandResult<Guid>{ 
                    message = "Ops! Você não pode viajar para a mesma dimensão que você está, selecione outra.",
                    success = false,
                    httpStatusCode = HttpStatusCode.BadRequest
                };
            }

            DimensionTravelled dimensionTravelled = _mapper.Map<AddDimensionTravelledInputModel, DimensionTravelled>(request);
            dimensionTravelled.IdDimensionBefore = (lastDimensionTravelled != null ? lastDimensionTravelled.IdDimensionCurrent : null);
            await _repositoryDimensionTravelled.Insert(dimensionTravelled);
            await _unitOfWork.Commit();

            return new CommandResult<Guid>
            {
                response = dimensionTravelled.Id,
                message = $"Viagem criada com sucesso!",
                success = true,
                httpStatusCode = HttpStatusCode.Created
            };
        }
    }
}
