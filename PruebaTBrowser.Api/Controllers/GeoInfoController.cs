using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaTBrowser.Application.Feature.Ciudades.Queries;
using PruebaTBrowser.Application.Feature.Departamentos.Queries;
using PruebaTBrowser.Application.Feature.Paises.Queries;
using PruebaTBrowser.Shared.Models;

namespace PruebaTBrowser.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeoInfoController : ControllerBase
    {
        private readonly ILogger<GeoInfoController> _logger;
        private readonly IMediator _mediator;

        public GeoInfoController(ILogger<GeoInfoController> logger, IMediator mediator)
        {
            this._logger = logger;
            this._mediator = mediator;
        }

        [HttpGet("cities")]
        public async Task<ActionResult<List<CiudadViewModel>>> GetCities([FromQuery] int? DepartamentoId)
        {
            var response = await _mediator.Send(new CiudadGetQuery { DepartamentoId = DepartamentoId });

            return Ok(response);
        }

        [HttpGet("Departamentos")]
        public async Task<ActionResult<List<DepartamentoViewModel>>> GetDepartamentos([FromQuery] int? CoutryId)
        {
            var response = await _mediator.Send(new DepartamentoGetQuery { PaisId = CoutryId });

            return Ok(response);
        }

        [HttpGet("countries")]
        public async Task<ActionResult<List<PaisViewModel>>> GetCountries()
        {
            var response = await _mediator.Send(new PaisGetQuery());

            return Ok(response);
        }
    }
}
