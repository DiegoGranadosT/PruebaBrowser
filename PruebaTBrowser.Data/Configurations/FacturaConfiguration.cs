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
    public class FacturaConfiguration : IEntityTypeConfiguration<Factura>
    {
        public void Configure(EntityTypeBuilder<Factura> builder)
        {
            builder.HasData
                (
                    new Factura { Id = 1, MedioPagoId = 1, Fecha = DateTime.UtcNow, Valor = 200 },
                    new Factura { Id = 2, MedioPagoId = 3, Fecha = DateTime.UtcNow, Valor = 200 },
                    new Factura { Id = 3, MedioPagoId = 1, Fecha = DateTime.UtcNow, Valor = 200 },
                    new Factura { Id = 4, MedioPagoId = 4, Fecha = DateTime.UtcNow, Valor = 200 },
                    new Factura { Id = 5, MedioPagoId = 1, Fecha = DateTime.UtcNow, Valor = 200 },
                    new Factura { Id = 6, MedioPagoId = 3, Fecha = DateTime.UtcNow, Valor = 200 },
                    new Factura { Id = 7, MedioPagoId = 1, Fecha = DateTime.UtcNow, Valor = 200 },
                    new Factura { Id = 8, MedioPagoId = 2, Fecha = DateTime.UtcNow, Valor = 200 },
                    new Factura { Id = 9, MedioPagoId = 1, Fecha = DateTime.UtcNow, Valor = 200 },
                    new Factura { Id = 10, MedioPagoId = 4, Fecha = DateTime.UtcNow, Valor = 200 },
                    new Factura { Id = 11, MedioPagoId = 2, Fecha = DateTime.UtcNow, Valor = 200 },
                    new Factura { Id = 12, MedioPagoId = 5, Fecha = DateTime.UtcNow, Valor = 200 },
                    new Factura { Id = 13, MedioPagoId = 1, Fecha = DateTime.UtcNow, Valor = 200 },
                    new Factura { Id = 14, MedioPagoId = 2, Fecha = DateTime.UtcNow, Valor = 200 },
                    new Factura { Id = 15, MedioPagoId = 1, Fecha = DateTime.UtcNow, Valor = 200 },
                    new Factura { Id = 16, MedioPagoId = 2, Fecha = DateTime.UtcNow, Valor = 200 },
                    new Factura { Id = 17, MedioPagoId = 5, Fecha = DateTime.UtcNow, Valor = 200 } 
                );
        }
    }
}
