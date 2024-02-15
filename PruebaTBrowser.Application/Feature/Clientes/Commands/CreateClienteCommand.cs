using AutoMapper;
using MediatR;
using PruebaTBrowser.Data.Repositories.Persistence.Repositories;
using PruebaTBrowser.Models.Entities;
using PruebaTBrowser.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTBrowser.Application.Feature.Clientes.Commands
{
    public class CreateClienteCommand : IRequest<ClienteViewModel>
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
        public string Genero { get; set; }
        public int EmpresaId { get; set; }
        public int CiudadId { get; set; }
    }

    public class CreateClienteHandle : IRequestHandler<CreateClienteCommand, ClienteViewModel>
    {
        private readonly IRepository<Cliente, int> _clienteRepo;
        private readonly IMapper _mapper;

        public CreateClienteHandle(IRepository<Cliente, int> clienteRepo, IMapper mapper)
        {
            this._clienteRepo = clienteRepo;
            this._mapper = mapper;
        }
        public async Task<ClienteViewModel> Handle(CreateClienteCommand request, CancellationToken cancellationToken)
        {
            var model = _mapper.Map<Cliente>(request);

            var response = await _clienteRepo.AddAsync(model);

            return _mapper.Map<ClienteViewModel>(response);
        }
    }
}
