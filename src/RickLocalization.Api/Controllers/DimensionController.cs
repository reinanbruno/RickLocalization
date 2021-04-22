using MediatR;
using Microsoft.AspNetCore.Mvc;
using RickLocalization.Application.Queries.Dimensions.GetAll;
using System.Threading.Tasks;

namespace RickLocalization.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    public sealed class DimensionController : Controller
    {
        private readonly IMediator _mediator;

        public DimensionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Carregar todas dimensões
        /// </summary>
        /// <response code="200">Listado com sucesso.</response>
        /// <response code="404">Não houve dimensões encontrados.</response>
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] GetAllDimensionQuery request)
        {
            return Ok(await _mediator.Send(request));
        }
    }
}
