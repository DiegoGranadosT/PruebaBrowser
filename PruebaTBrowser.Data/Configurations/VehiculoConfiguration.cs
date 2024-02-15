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
    public class VehiculoConfiguration : IEntityTypeConfiguration<Vehiculo>
    {
        public void Configure(EntityTypeBuilder<Vehiculo> builder)
        {
            builder.HasData
                (
                    new Vehiculo { Id = 1, Marca = "KIA", Año = "2015", Modelo = "", Placa = "DAW245", Refernecia = "" },
                    new Vehiculo { Id = 2, Marca = "MAZDA", Año = "2018", Modelo = "", Placa = "HND135", Refernecia = "" },
                    new Vehiculo { Id = 3, Marca = "RENAULD", Año = "2023", Modelo = "", Placa = "DAW578", Refernecia = "" },
                    new Vehiculo { Id = 4, Marca = "RENAULD", Año = "2023", Modelo = "", Placa = "DFA123", Refernecia = "" },
                    new Vehiculo { Id = 5, Marca = "MAZDA", Año = "2018", Modelo = "", Placa = "TRE455", Refernecia = "" },
                    new Vehiculo { Id = 6, Marca = "RENAULD", Año = "2018", Modelo = "", Placa = "NJD145", Refernecia = "" },
                    new Vehiculo { Id = 7, Marca = "RENAULD", Año = "2015", Modelo = "", Placa = "SDD231", Refernecia = "" },
                    new Vehiculo { Id = 8, Marca = "KIA", Año = "2018", Modelo = "", Placa = "DAW234", Refernecia = "" },
                    new Vehiculo { Id = 9, Marca = "MAZDA", Año = "2015", Modelo = "", Placa = "GHJJ353", Refernecia = "" },
                    new Vehiculo { Id = 10, Marca = "MAZDA", Año = "2023", Modelo = "", Placa = "DWA123", Refernecia = "" },
                    new Vehiculo { Id = 11, Marca = "KIA", Año = "2018", Modelo = "", Placa = "HJU897", Refernecia = "" },
                    new Vehiculo { Id = 12, Marca = "RENAULD", Año = "2015", Modelo = "", Placa = "FGH678", Refernecia = "" },
                    new Vehiculo { Id = 13, Marca = "RENAULD", Año = "2007", Modelo = "", Placa = "DGT678", Refernecia = "" },
                    new Vehiculo { Id = 14, Marca = "KIA", Año = "2023", Modelo = "", Placa = "NJM834", Refernecia = "" },
                    new Vehiculo { Id = 15, Marca = "KIA", Año = "2015", Modelo = "", Placa = "MKJ345", Refernecia = "" }
                );
        }
    }
}
