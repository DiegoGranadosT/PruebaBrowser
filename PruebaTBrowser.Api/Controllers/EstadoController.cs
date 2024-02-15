using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaTBrowser.Application.Feature.Estados.Queries;
using PruebaTBrowser.Shared.Models;

namespace PruebaTBrowser.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoController : ControllerBase
    {
        private readonly ILogger<EstadoController> _logger;
        private readonly IMediator _mediator;

        public EstadoController(ILogger<EstadoController> logger, IMediator mediator)
        {
            this._logger = logger;
            this._mediator = mediator;
        }

        [HttpGet()]
        public async Task<ActionResult<List<EstadoViewModel>>> Get()
        {
            var response = await _mediator.Send(new EstadoGetQuery());

            return Ok(response);
        }
    }
}
