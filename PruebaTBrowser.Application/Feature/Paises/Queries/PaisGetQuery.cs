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

namespace PruebaTBrowser.Application.Feature.Paises.Queries
{
    public class PaisGetQuery : IRequest<List<PaisViewModel>>
    {
    }

    public class PaisGetHandler : IRequestHandler<PaisGetQuery, List<PaisViewModel>>
    {
        private readonly IRepository<Pais, int> _PaisRepo;
        private readonly IMapper _mapper;

        public PaisGetHandler(IRepository<Pais, int> PaisRepo, IMapper mapper)
        {
            _PaisRepo = PaisRepo;
            _mapper = mapper;
        }
        public async Task<List<PaisViewModel>> Handle(PaisGetQuery request, CancellationToken cancellationToken)
        {
            var query = await _PaisRepo.Query()
                .ToListAsync();

            return _mapper.Map<List<PaisViewModel>>(query);
        }
    }
}
