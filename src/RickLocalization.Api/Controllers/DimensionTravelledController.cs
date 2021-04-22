using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RickLocalization.Application.Commands.Contracts;
using RickLocalization.Application.Commands.DimensionsTravelled.Add;
using RickLocalization.Application.Queries.DimensionsTravelled.GetTravels;
using RickLocalization.Application.Queries.Shared.Pagination;
using System;
using System.Net.Mime;
using System.Threading.Tasks;

namespace RickLocalization.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [Consumes(MediaTypeNames.Application.Json)]
    public sealed class DimensionTravelledController : Controller
    {
        private readonly IMediator _mediator;

        public DimensionTravelledController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Buscar histórico de viagens
        /// </summary>
        /// <response code="200">Encontrado com sucesso.</response>
        /// <response code="204">Não há contéudo.</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PaginationViewModel<GetTravelsViewModel>))]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> GetTravels([FromQuery] GetTravelsInputModel request)
        {
            PaginationViewModel<GetTravelsViewModel> response = await _mediator.Send(request);

            if(response.response.Count == 0)
            {
                return NoContent();
            }

            return Ok(response);
        }

        /// <summary>
        /// Inserir uma nova viagem
        /// </summary>
        /// <response code="201">Inserido com sucesso.</response>
        /// <response code="400">Você não pode inserir uma nova viagame para a mesma dimensão que está.</response>
        /// <response code="404">Dados da chave estrangeira do rick ou da dimensão não encontrados.</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(Guid))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Insert([FromBody] AddDimensionTravelledInputModel request)
        {
            ICommandResult<Guid> commandResult = await _mediator.Send(request);
            return StatusCode((int)commandResult.httpStatusCode, commandResult);
        }
    }
}
