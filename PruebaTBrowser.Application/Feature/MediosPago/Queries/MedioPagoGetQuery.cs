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

namespace PruebaTBrowser.Application.Feature.MediosPago.Queries
{
    public class MedioPagoGetQuery : IRequest<List<MedioPagoViewModel>>
    {
    }

    public class MedioPagoGetHandler : IRequestHandler<MedioPagoGetQuery, List<MedioPagoViewModel>>
    {
        private readonly IRepository<MedioPago, int> _medioPaRepo;
        private readonly IMapper _mapper;

        public MedioPagoGetHandler(IRepository<MedioPago, int> medioPaRepo, IMapper mapper)
        {
            this._medioPaRepo = medioPaRepo;
            this._mapper = mapper;
        }
        public async Task<List<MedioPagoViewModel>> Handle(MedioPagoGetQuery request, CancellationToken cancellationToken)
        {
            var query = await _medioPaRepo.Query()
                .ToListAsync();

            return _mapper.Map<List<MedioPagoViewModel>>(query);
        }
    }
}
