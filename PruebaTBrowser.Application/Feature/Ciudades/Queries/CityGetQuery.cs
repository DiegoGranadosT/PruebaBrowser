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

namespace PruebaTBrowser.Application.Feature.Ciudades.Queries
{
    public class CiudadGetQuery : IRequest<List<CiudadViewModel>>
    {
        public int? DepartamentoId { get; set; }
    }

    public class CiudadGetHandler : IRequestHandler<CiudadGetQuery, List<CiudadViewModel>>
    {
        private readonly IRepository<Ciudad, int> _CiudadRepo;
        private readonly IMapper _mapper;

        public CiudadGetHandler(IRepository<Ciudad, int> CiudadRepo, IMapper mapper)
        {
            _CiudadRepo = CiudadRepo;
            _mapper = mapper;
        }
        public async Task<List<CiudadViewModel>> Handle(CiudadGetQuery request, CancellationToken cancellationToken)
        {
            var query = await _CiudadRepo.Query()
                .Where(x => !request.DepartamentoId.HasValue || x.DepartamentoId == request.DepartamentoId.Value)
                .ToListAsync();

            return _mapper.Map<List<CiudadViewModel>>(query);
        }
    }
}
