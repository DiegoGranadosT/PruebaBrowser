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
    public class ReservaConfiguration : IEntityTypeConfiguration<Reserva>
    {
        public void Configure(EntityTypeBuilder<Reserva> builder)
        {
            builder.HasData
                (
                    new Reserva { Id = 1, EstadoId = 1, SolucitudId = 1, FacturaId = 1},
                    new Reserva { Id = 2, EstadoId = 1, SolucitudId = 4, FacturaId = 2},
                    new Reserva { Id = 3, EstadoId = 1, SolucitudId = 7, FacturaId = 3},
                    new Reserva { Id = 4, EstadoId = 1, SolucitudId = 9, FacturaId = 4},
                    new Reserva { Id = 5, EstadoId = 1, SolucitudId = 10, FacturaId = 5},
                    new Reserva { Id = 6, EstadoId = 2, SolucitudId = 11, FacturaId = 6},
                    new Reserva { Id = 7, EstadoId = 4, SolucitudId = 12, FacturaId = 7},
                    new Reserva { Id = 8, EstadoId = 3, SolucitudId = 14, FacturaId = 8},
                    new Reserva { Id = 9, EstadoId = 3, SolucitudId = 15, FacturaId = 9},
                    new Reserva { Id = 10, EstadoId = 2, SolucitudId = 17, FacturaId = 10},
                    new Reserva { Id = 11, EstadoId = 4, SolucitudId = 20, FacturaId = 11},
                    new Reserva { Id = 12, EstadoId = 2, SolucitudId = 21, FacturaId = 12},
                    new Reserva { Id = 13, EstadoId = 3, SolucitudId = 23, FacturaId = 13},
                    new Reserva { Id = 14, EstadoId = 2, SolucitudId = 25, FacturaId = 14},
                    new Reserva { Id = 15, EstadoId = 3, SolucitudId = 27, FacturaId = 15},
                    new Reserva { Id = 16, EstadoId = 4, SolucitudId = 28, FacturaId = 16},
                    new Reserva { Id = 17, EstadoId = 1, SolucitudId = 29, FacturaId = 17}
                );
        }
    }
}
