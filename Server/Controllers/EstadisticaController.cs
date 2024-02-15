using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Asn1.Ocsp;
using PruebaTBrowser.Application.Feature.Estadisticas;
using PruebaTBrowser.Shared.Models;

namespace PruebaTBrowser.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadisticaController : ControllerBase
    {
        private readonly ILogger<EstadisticaController> _logger;
        private readonly IMediator _mediator;

        public EstadisticaController(ILogger<EstadisticaController> logger, IMediator mediator)
        {
            this._logger = logger;
            this._mediator = mediator;
        }

        [HttpGet("cantidadClientes")]
        public async Task<ActionResult<ClientesConsultaRentaModel>> GetCantidadClienteConsulta() 
        {
            try
            {
                var response = await _mediator.Send(new ClientesConsultaRenta());

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        [HttpGet("clientes/{ciudadId}")]
        public async Task<ActionResult<List<ClienteViewModel>>> GetCliente(int ciudadId) 
        {
            try
            {
                var response = await _mediator.Send(new Clientes { CiudadId = ciudadId});

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        [HttpGet("reserva/{medioPagoId}")]
        public async Task<ActionResult<List<ReservaViewModel>>> GetReservaByMedioPago(int medioPagoId) 
        {
            try
            {
                var response = await _mediator.Send(new ReservasByMedioPagoIdQuery { MedioPagoId = medioPagoId});

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        [HttpGet("reserva/{estadoId}")]
        public async Task<ActionResult<List<ReservaViewModel>>> GetReservaByEstadoId(int estadoId) 
        {
            try
            {
                var response = await _mediator.Send(new ReservasByEstadoIdQuery { EstadoId = estadoId});

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
