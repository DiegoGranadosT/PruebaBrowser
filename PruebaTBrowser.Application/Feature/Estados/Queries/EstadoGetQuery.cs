using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PruebaTBrowser.Data.Repositories.Persistence.Repositories;
using PruebaTBrowser.Models.Entities;
using PruebaTBrowser.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTBrowser.Application.Feature.Estados.Queries
{
    public class EstadoGetQuery : IRequest<List<EstadoViewModel>>
    {
    }

    public class EstadoGetHandler : IRequestHandler<EstadoGetQuery, List<EstadoViewModel>>
    {
        private readonly IRepository<Estado, int> _medioPaRepo;
        private readonly IMapper _mapper;

        public EstadoGetHandler(IRepository<Estado, int> medioPaRepo, IMapper mapper)
        {
            _medioPaRepo = medioPaRepo;
            _mapper = mapper;
        }
        public async Task<List<EstadoViewModel>> Handle(EstadoGetQuery request, CancellationToken cancellationToken)
        {
            var query = await _medioPaRepo.Query()
                .ToListAsync();

            return _mapper.Map<List<EstadoViewModel>>(query);
        }
    }
}
