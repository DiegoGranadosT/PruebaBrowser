using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaTBrowser.Application.Feature.Clientes.Commands;
using PruebaTBrowser.Shared.Models;
using ZstdSharp.Unsafe;

namespace PruebaTBrowser.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<AccountController> _logger;

        public AccountController(IMediator mediator, ILogger<AccountController> logger)
        {
            this._mediator = mediator;
            this._logger = logger;
        }

        [HttpPost]
        public async Task<ActionResult<ClienteViewModel>> Register(CreateClienteCommand request) 
        {
            try
            {
                var response = await _mediator.Send(request);

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
