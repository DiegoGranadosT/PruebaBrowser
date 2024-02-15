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
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasData
                (
                    new Cliente { Id = 1, Nombres = "Laura", Apellidos = "González", Edad = "25" , Genero = "Masculino", Telefono = "", CorreoElectronico = "", EmpresaId = 1, CiudadId = 1},
                    new Cliente { Id = 2, Nombres = "Andrés", Apellidos = "Jiménez", Edad = "43" , Genero = "Femenino", Telefono = "", CorreoElectronico = "", EmpresaId = 1, CiudadId = 1},
                    new Cliente { Id = 3, Nombres = "Carlos", Apellidos = "Martínez", Edad = "63" , Genero = "Femenino", Telefono = "", CorreoElectronico = "", EmpresaId = 1, CiudadId = 1},
                    new Cliente { Id = 4, Nombres = "Sofía", Apellidos = "Jiménez", Edad = "25" , Genero = "Masculino", Telefono = "", CorreoElectronico = "", EmpresaId = 1, CiudadId = 1},
                    new Cliente { Id = 5, Nombres = "Valentina", Apellidos = "García", Edad = "16" , Genero = "Femenino", Telefono = "", CorreoElectronico = "", EmpresaId = 1, CiudadId = 1},
                    new Cliente { Id = 6, Nombres = "Laura", Apellidos = "Torres", Edad = "46" , Genero = "Femenino", Telefono = "", CorreoElectronico = "", EmpresaId = 1, CiudadId = 2},
                    new Cliente { Id = 7, Nombres = "Daniel", Apellidos = "González", Edad = "78" , Genero = "Femenino", Telefono = "", CorreoElectronico = "", EmpresaId = 1, CiudadId = 2},
                    new Cliente { Id = 8, Nombres = "Mariana", Apellidos = "González", Edad = "47" , Genero = "Masculino", Telefono = "", CorreoElectronico = "", EmpresaId = 1, CiudadId = 2},
                    new Cliente { Id = 9, Nombres = "Isabella", Apellidos = "Rojas", Edad = "37" , Genero = "Masculino", Telefono = "", CorreoElectronico = "", EmpresaId = 1, CiudadId = 2},
                    new Cliente { Id = 10, Nombres = "Ana", Apellidos = "Díaz", Edad = "46" , Genero = "Femenino", Telefono = "", CorreoElectronico = "", EmpresaId = 1, CiudadId = 4},
                    new Cliente { Id = 11, Nombres = "Carlos", Apellidos = "Muñoz", Edad = "69" , Genero = "Masculino", Telefono = "", CorreoElectronico = "", EmpresaId = 1, CiudadId = 4},
                    new Cliente { Id = 12, Nombres = "Mariana", Apellidos = "González", Edad = "47" , Genero = "Femenino", Telefono = "", CorreoElectronico = "", EmpresaId = 1, CiudadId = 4},
                    new Cliente { Id = 13, Nombres = "Diego", Apellidos = "Pérez", Edad = "33" , Genero = "Femenino", Telefono = "", CorreoElectronico = "", EmpresaId = 1, CiudadId = 4},
                    new Cliente { Id = 14, Nombres = "Laura", Apellidos = "Vargas", Edad = "47" , Genero = "Masculino", Telefono = "", CorreoElectronico = "", EmpresaId = 1, CiudadId = 4},
                    new Cliente { Id = 15, Nombres = "Juan", Apellidos = "Gómez", Edad = "46" , Genero = "Femenino", Telefono = "", CorreoElectronico = "", EmpresaId = 1, CiudadId = 4},
                    new Cliente { Id = 16, Nombres = "David", Apellidos = "Romero", Edad = "54" , Genero = "Masculino", Telefono = "", CorreoElectronico = "", EmpresaId = 1, CiudadId = 3},
                    new Cliente { Id = 17, Nombres = "Carlos", Apellidos = "Martínez", Edad = "35" , Genero = "Masculino", Telefono = "", CorreoElectronico = "", EmpresaId = 1, CiudadId = 3},
                    new Cliente { Id = 18, Nombres = "Alejandro", Apellidos = "Muñoz", Edad = "46" , Genero = "Femenino", Telefono = "", CorreoElectronico = "", EmpresaId = 1, CiudadId = 3},
                    new Cliente { Id = 19, Nombres = "Camila", Apellidos = "Díaz", Edad = "27" , Genero = "Femenino", Telefono = "", CorreoElectronico = "", EmpresaId = 1, CiudadId = 1},
                    new Cliente { Id = 20, Nombres = "Santiago", Apellidos = "Romero", Edad = "46" , Genero = "Masculino", Telefono = "", CorreoElectronico = "", EmpresaId = 1, CiudadId = 1},
                    new Cliente { Id = 21, Nombres = "Laura", Apellidos = "Rojas", Edad = "35" , Genero = "Masculino", Telefono = "", CorreoElectronico = "", EmpresaId = 1, CiudadId = 1},
                    new Cliente { Id = 22, Nombres = "Diego", Apellidos = "González", Edad = "56" , Genero = "Femenino", Telefono = "", CorreoElectronico = "", EmpresaId = 1, CiudadId = 2},
                    new Cliente { Id = 23, Nombres = "Mateo", Apellidos = "Vargas", Edad = "34" , Genero = "Masculino", Telefono = "", CorreoElectronico = "", EmpresaId = 1, CiudadId = 1},
                    new Cliente { Id = 24, Nombres = "Carlos", Apellidos = "Pérez", Edad = "34" , Genero = "Masculino", Telefono = "", CorreoElectronico = "", EmpresaId = 1, CiudadId = 1},
                    new Cliente { Id = 25, Nombres = "Samuel", Apellidos = "Jiménez", Edad = "37" , Genero = "Femenino", Telefono = "", CorreoElectronico = "", EmpresaId = 1, CiudadId = 2},
                    new Cliente { Id = 26, Nombres = "Camila", Apellidos = "Torres", Edad = "56" , Genero = "Femenino", Telefono = "", CorreoElectronico = "", EmpresaId = 1, CiudadId = 1},
                    new Cliente { Id = 27, Nombres = "Luis", Apellidos = "García", Edad = "67" , Genero = "Masculino", Telefono = "", CorreoElectronico = "", EmpresaId = 1, CiudadId = 4},
                    new Cliente { Id = 28, Nombres = "Mateo", Apellidos = "González", Edad = "46" , Genero = "Masculino", Telefono = "", CorreoElectronico = "", EmpresaId = 1, CiudadId = 4},
                    new Cliente { Id = 29, Nombres = "Andrés", Apellidos = "Jiménez", Edad = "46" , Genero = "Femenino", Telefono = "", CorreoElectronico = "", EmpresaId = 1, CiudadId = 6},
                    new Cliente { Id = 30, Nombres = "Ana", Apellidos = "Martínez", Edad = "58" , Genero = "Masculino", Telefono = "", CorreoElectronico = "", EmpresaId = 1, CiudadId = 7},
                    new Cliente { Id = 31, Nombres = "Mariana", Apellidos = "Muñoz", Edad = "37" , Genero = "Femenino", Telefono = "", CorreoElectronico = "", EmpresaId = 1, CiudadId = 4},
                    new Cliente { Id = 32, Nombres = "Diego", Apellidos = "Romero", Edad = "26" , Genero = "Masculino", Telefono = "", CorreoElectronico = "", EmpresaId = 1, CiudadId = 6},
                    new Cliente { Id = 33, Nombres = "Isabella", Apellidos = "Pérez", Edad = "46" , Genero = "Femenino", Telefono = "", CorreoElectronico = "", EmpresaId = 1, CiudadId = 6},
                    new Cliente { Id = 34, Nombres = "Carlos", Apellidos = "Romero", Edad = "26" , Genero = "Masculino", Telefono = "", CorreoElectronico = "", EmpresaId = 1, CiudadId = 7},
                    new Cliente { Id = 35, Nombres = "Mateo", Apellidos = "Gómez", Edad = "26" , Genero = "Masculino", Telefono = "", CorreoElectronico = "", EmpresaId = 1, CiudadId = 7},
                    new Cliente { Id = 36, Nombres = "Samuel", Apellidos = "Gómez", Edad = "20" , Genero = "Femenino", Telefono = "", CorreoElectronico = "", EmpresaId = 1, CiudadId = 7}
                );
        }
    }
}
