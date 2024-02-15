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
    public class EstadoConfiguration : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder.HasData
                (
                    new Estado { Id = 1, Nombre = "Activo" },
                    new Estado { Id = 2, Nombre = "Finalizado" },
                    new Estado { Id = 3, Nombre = "Cancelado" },
                    new Estado { Id = 4, Nombre = "En Espera" }
                );
        }
    }
}
