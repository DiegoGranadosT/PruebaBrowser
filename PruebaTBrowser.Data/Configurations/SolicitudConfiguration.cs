using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PruebaTBrowser.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTBrowser.Data.Configurations
{
    public class SolicitudConfiguration : IEntityTypeConfiguration<Solicitud>
    {
        public void Configure(EntityTypeBuilder<Solicitud> builder)
        {
            builder.HasData
                (
                    new Solicitud { Id = 1, ClienteId = 1, FechaFin = DateTime.UtcNow,FechaInicio = DateTime.UtcNow, RentaId = 1 },
                    new Solicitud { Id = 2, ClienteId = 2, FechaFin = DateTime.UtcNow,FechaInicio = DateTime.UtcNow, RentaId = 2 },
                    new Solicitud { Id = 3, ClienteId = 3, FechaFin = DateTime.UtcNow,FechaInicio = DateTime.UtcNow, RentaId = 5 },
                    new Solicitud { Id = 4, ClienteId = 4, FechaFin = DateTime.UtcNow,FechaInicio = DateTime.UtcNow, RentaId = 7 },
                    new Solicitud { Id = 5, ClienteId = 5, FechaFin = DateTime.UtcNow,FechaInicio = DateTime.UtcNow, RentaId = 9 },
                    new Solicitud { Id = 6, ClienteId = 6, FechaFin = DateTime.UtcNow,FechaInicio = DateTime.UtcNow, RentaId = 10 },
                    new Solicitud { Id = 7, ClienteId = 7, FechaFin = DateTime.UtcNow,FechaInicio = DateTime.UtcNow, RentaId = 11 },
                    new Solicitud { Id = 8, ClienteId = 8, FechaFin = DateTime.UtcNow,FechaInicio = DateTime.UtcNow, RentaId = 14 },
                    new Solicitud { Id = 9, ClienteId = 9, FechaFin = DateTime.UtcNow,FechaInicio = DateTime.UtcNow, RentaId = 1 },
                    new Solicitud { Id = 10, ClienteId = 10, FechaFin = DateTime.UtcNow,FechaInicio = DateTime.UtcNow, RentaId = 1 },
                    new Solicitud { Id = 11, ClienteId = 11, FechaFin = DateTime.UtcNow,FechaInicio = DateTime.UtcNow, RentaId = 2 },
                    new Solicitud { Id = 12, ClienteId = 12, FechaFin = DateTime.UtcNow,FechaInicio = DateTime.UtcNow, RentaId = 3 },
                    new Solicitud { Id = 13, ClienteId = 14, FechaFin = DateTime.UtcNow,FechaInicio = DateTime.UtcNow, RentaId = 15 },
                    new Solicitud { Id = 14, ClienteId = 14, FechaFin = DateTime.UtcNow,FechaInicio = DateTime.UtcNow, RentaId = 18 },
                    new Solicitud { Id = 15, ClienteId = 20, FechaFin = DateTime.UtcNow,FechaInicio = DateTime.UtcNow, RentaId = 13 },
                    new Solicitud { Id = 16, ClienteId = 22, FechaFin = DateTime.UtcNow,FechaInicio = DateTime.UtcNow, RentaId = 13 },
                    new Solicitud { Id = 17, ClienteId = 24, FechaFin = DateTime.UtcNow,FechaInicio = DateTime.UtcNow, RentaId = 1 },
                    new Solicitud { Id = 18, ClienteId = 26, FechaFin = DateTime.UtcNow,FechaInicio = DateTime.UtcNow, RentaId = 2 },
                    new Solicitud { Id = 19, ClienteId = 27, FechaFin = DateTime.UtcNow,FechaInicio = DateTime.UtcNow, RentaId = 5 },
                    new Solicitud { Id = 20, ClienteId = 28, FechaFin = DateTime.UtcNow,FechaInicio = DateTime.UtcNow, RentaId = 5 },
                    new Solicitud { Id = 21, ClienteId = 13, FechaFin = DateTime.UtcNow,FechaInicio = DateTime.UtcNow, RentaId = 19 },
                    new Solicitud { Id = 22, ClienteId = 34, FechaFin = DateTime.UtcNow,FechaInicio = DateTime.UtcNow, RentaId = 2 },
                    new Solicitud { Id = 23, ClienteId = 21, FechaFin = DateTime.UtcNow,FechaInicio = DateTime.UtcNow, RentaId = 9 },
                    new Solicitud { Id = 24, ClienteId = 1, FechaFin = DateTime.UtcNow,FechaInicio = DateTime.UtcNow, RentaId = 7 },
                    new Solicitud { Id = 25, ClienteId = 31, FechaFin = DateTime.UtcNow,FechaInicio = DateTime.UtcNow, RentaId = 7 },
                    new Solicitud { Id = 26, ClienteId = 33, FechaFin = DateTime.UtcNow,FechaInicio = DateTime.UtcNow, RentaId = 8 },
                    new Solicitud { Id = 27, ClienteId = 34, FechaFin = DateTime.UtcNow,FechaInicio = DateTime.UtcNow, RentaId = 5 },
                    new Solicitud { Id = 28, ClienteId = 35, FechaFin = DateTime.UtcNow,FechaInicio = DateTime.UtcNow, RentaId = 3 },
                    new Solicitud { Id = 29, ClienteId = 36, FechaFin = DateTime.UtcNow,FechaInicio = DateTime.UtcNow, RentaId = 1 }
                );
        }
    }
}
