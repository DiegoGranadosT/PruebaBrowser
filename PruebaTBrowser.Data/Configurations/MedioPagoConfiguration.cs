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
    public class MedioPagoConfiguration : IEntityTypeConfiguration<MedioPago>
    {
        public void Configure(EntityTypeBuilder<MedioPago> builder)
        {
            builder.HasData
                (
                    new MedioPago { Id = 1, Nombre = "Pago en destino" },
                    new MedioPago { Id = 2, Nombre = "Tarjeta de crédito" },
                    new MedioPago { Id = 3, Nombre = "Tarjeta de debito" },
                    new MedioPago { Id = 4, Nombre = "PSE" },
                    new MedioPago { Id = 5, Nombre = "PayPal" }

                );
        }
    }
}
