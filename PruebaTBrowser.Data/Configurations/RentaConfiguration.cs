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
    public class RentaConfiguration : IEntityTypeConfiguration<Renta>
    {
        public void Configure(EntityTypeBuilder<Renta> builder)
        {
            builder.HasData
                (
                    new Renta { Id = 1, Periodo = Models.EntiityBases.Periodo.Trimestral, Valor = 3500 , VehiculoId = 1 },
                    new Renta { Id = 2, Periodo = Models.EntiityBases.Periodo.Dia, Valor = 65, VehiculoId = 1 },
                    new Renta { Id = 3, Periodo = Models.EntiityBases.Periodo.Anual, Valor = 5000, VehiculoId = 2 },
                    new Renta { Id = 4, Periodo = Models.EntiityBases.Periodo.Trimestral, Valor = 1200, VehiculoId = 3 },
                    new Renta { Id = 5, Periodo = Models.EntiityBases.Periodo.Semanal, Valor = 350, VehiculoId = 4 },
                    new Renta { Id = 6, Periodo = Models.EntiityBases.Periodo.Anual, Valor = 6500, VehiculoId = 5 },
                    new Renta { Id = 7, Periodo = Models.EntiityBases.Periodo.Semestral, Valor = 2000, VehiculoId = 6 },
                    new Renta { Id = 8, Periodo = Models.EntiityBases.Periodo.Dia, Valor = 25, VehiculoId = 6 },
                    new Renta { Id = 9, Periodo = Models.EntiityBases.Periodo.Semestral, Valor = 2200, VehiculoId = 6 },
                    new Renta { Id = 10, Periodo = Models.EntiityBases.Periodo.Trimestral, Valor = 900, VehiculoId = 7 },
                    new Renta { Id = 11, Periodo = Models.EntiityBases.Periodo.Trimestral, Valor = 850, VehiculoId = 8 },
                    new Renta { Id = 12, Periodo = Models.EntiityBases.Periodo.Dia, Valor = 90, VehiculoId = 9 },
                    new Renta { Id = 13, Periodo = Models.EntiityBases.Periodo.Mes, Valor = 250, VehiculoId = 10 },
                    new Renta { Id = 14, Periodo = Models.EntiityBases.Periodo.Semanal, Valor = 180, VehiculoId = 11 },
                    new Renta { Id = 15, Periodo = Models.EntiityBases.Periodo.Dia, Valor = 29, VehiculoId = 12 },
                    new Renta { Id = 16, Periodo = Models.EntiityBases.Periodo.Anual, Valor = 3600, VehiculoId = 13 },
                    new Renta { Id = 17, Periodo = Models.EntiityBases.Periodo.Anual, Valor = 2800, VehiculoId = 14 },
                    new Renta { Id = 18, Periodo = Models.EntiityBases.Periodo.Semanal, Valor = 450, VehiculoId = 15 },
                    new Renta { Id = 19, Periodo = Models.EntiityBases.Periodo.Trimestral, Valor = 600, VehiculoId = 15 }
                );
        }
    }
}
