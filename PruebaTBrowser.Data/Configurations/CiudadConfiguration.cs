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
    public class CiudadConfiguration : IEntityTypeConfiguration<Ciudad>
    {
        public void Configure(EntityTypeBuilder<Ciudad> builder)
        {
            builder.HasData
                (
                    new Ciudad { Id = 1, Nombre = "Yopal", DepartamentoId = 1 },
                    new Ciudad { Id = 2, Nombre = "Aguazul", DepartamentoId = 1 },
                    new Ciudad { Id = 3, Nombre = "Bogota", DepartamentoId = 3 },
                    new Ciudad { Id = 4, Nombre = "Sogamoso", DepartamentoId = 2 },
                    new Ciudad { Id = 5, Nombre = "Paipa", DepartamentoId = 2 },
                    new Ciudad { Id = 6, Nombre = "Tunja", DepartamentoId = 2 },
                    new Ciudad { Id = 7, Nombre = "Monterrey", DepartamentoId = 1 }

                );
        }
    }
}
