using MediatR;
using Microsoft.AspNetCore.Mvc;
using RickLocalization.Application.Queries.Ricks.GetAll;
using RickLocalization.Application.Queries.Ricks.GetDetails;
using System.Threading.Tasks;

namespace RickLocalization.Api.Controllers
{
    [Route("api/[controller]/[action]")]
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
        public async Task<IActionResult> GetAll([FromQuery] GetAllRickInputModel request)
        {
            var response = await _mediator.Send(request);

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
        public async Task<IActionResult> GetDetails([FromQuery] GetDetailsRickInputModel request)
        {
            return Ok(await _mediator.Send(request));
        }

    }
}
