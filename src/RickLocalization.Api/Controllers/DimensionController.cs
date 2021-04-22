using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RickLocalization.Application.Queries.Dimensions.GetAll;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;

namespace RickLocalization.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [Consumes(MediaTypeNames.Application.Json)]
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
        /// <response code="204">Não há contéudo.</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<GetAllDimensionViewModel>))]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> GetAll([FromQuery] GetAllDimensionQuery request)
        {
            List<GetAllDimensionViewModel> response = await _mediator.Send(request);

            if(response.Count == 0)
            {
                return NoContent();
            }

            return Ok(response);
        }
    }
}
