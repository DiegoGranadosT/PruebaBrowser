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

namespace PruebaTBrowser.Application.Feature.Departamentos.Queries
{
    public class DepartamentoGetQuery : IRequest<List<DepartamentoViewModel>>
    {
        public int? PaisId { get; set; }
    }

    public class DepartamentoGetHandler : IRequestHandler<DepartamentoGetQuery, List<DepartamentoViewModel>>
    {
        private readonly IRepository<Departamento, int> _DepartamentoRepo;
        private readonly IMapper _mapper;

        public DepartamentoGetHandler(IRepository<Departamento, int> DepartamentoRepo, IMapper mapper)
        {
            _DepartamentoRepo = DepartamentoRepo;
            _mapper = mapper;
        }
        public async Task<List<DepartamentoViewModel>> Handle(DepartamentoGetQuery request, CancellationToken cancellationToken)
        {
            var query = await _DepartamentoRepo.Query()
                .Where(x => !request.PaisId.HasValue || x.PaisId == request.PaisId.Value)
                .ToListAsync();

            return _mapper.Map<List<DepartamentoViewModel>>(query);
        }
    }
}
