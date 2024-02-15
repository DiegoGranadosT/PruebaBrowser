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
    public class DepartamentoConfiguration : IEntityTypeConfiguration<Departamento>
    {
        public void Configure(EntityTypeBuilder<Departamento> builder)
        {
            builder.HasData
                (
                    new Departamento { Id = 1, Nombre = "Casanare", PaisId = 1 },
                    new Departamento { Id = 2, Nombre = "Boyaca", PaisId = 1 },
                    new Departamento { Id = 3, Nombre = "Cundinamarca", PaisId = 1 }
                );
        }
    }
}
