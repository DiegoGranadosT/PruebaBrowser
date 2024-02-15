using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaTBrowser.Application.Feature.Ciudades.Queries;
using PruebaTBrowser.Application.Feature.MediosPago.Queries;
using PruebaTBrowser.Shared.Models;

namespace PruebaTBrowser.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedioPagoController : ControllerBase
    {
        private readonly ILogger<MedioPagoController> _logger;
        private readonly IMediator _mediator;

        public MedioPagoController(ILogger<MedioPagoController> logger, IMediator mediator)
        {
            this._logger = logger;
            this._mediator = mediator;
        }

        [HttpGet()]
        public async Task<ActionResult<List<MedioPagoViewModel>>> Get()
        {
            var response = await _mediator.Send(new MedioPagoGetQuery() );

            return Ok(response);
        }
    }
}
