using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RickLocalization.Application.Queries.Ricks.GetAll;
using RickLocalization.Application.Queries.Ricks.GetDetails;
using RickLocalization.Application.Queries.Shared.Pagination;
using System.Net.Mime;
using System.Threading.Tasks;

namespace RickLocalization.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [Consumes(MediaTypeNames.Application.Json)]
    public sealed class RickController : Controller
    {
        private readonly IMediator _mediator;

        public RickController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Carregar todos ricks
        /// </summary>
        /// <response code="200">Listado com sucesso.</response>
        /// <response code="204">Não há contéudo.</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PaginationViewModel<GetAllRickViewModel>))]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> GetAll([FromQuery] GetAllRickInputModel request)
        {
            PaginationViewModel<GetAllRickViewModel> response = await _mediator.Send(request);

            if (response.response.Count == 0)
            {
                return NoContent();
            }

            return Ok(await _mediator.Send(request));
        }

        /// <summary>
        /// Buscar o rick por url
        /// </summary>
        /// <response code="200">Encontrado com sucesso.</response>
        /// <response code="404">Não foi encontrado.</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GetDetailsRickViewModel))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetDetails([FromQuery] GetDetailsRickInputModel request)
        {
            GetDetailsRickViewModel response = await _mediator.Send(request);

            if (response == null)
            {
                return NotFound();
            }

            return Ok(response);
        }

    }
}
