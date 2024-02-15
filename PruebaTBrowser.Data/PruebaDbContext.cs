using Microsoft.EntityFrameworkCore;
using PruebaTBrowser.Data.Configurations;
using PruebaTBrowser.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTBrowser.Data
{
    public class PruebaDbContext : DbContext
    {
        public DbSet<Ciudad> Ciudad { get; set; }
        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Pais> Pais { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Preferencia> Preferencia { get; set; }
        public DbSet<Renta> Renta { get; set; }
        public DbSet<Reserva> Reserva { get; set; }
        public DbSet<Solicitud> Solicitud { get; set; }
        public DbSet<Vehiculo> Vehiculo { get; set; }
        public DbSet<Factura> Factura { get; set; }
        public PruebaDbContext()
        {

        }

        public PruebaDbContext(DbContextOptions<PruebaDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MedioPagoConfiguration());
            modelBuilder.ApplyConfiguration(new PaisConfiguration());
            modelBuilder.ApplyConfiguration(new DepartamentoConfiguration());
            modelBuilder.ApplyConfiguration(new CiudadConfiguration());
            modelBuilder.ApplyConfiguration(new EmpresaConfiguration());
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration(new EstadoConfiguration());

            modelBuilder.ApplyConfiguration(new VehiculoConfiguration());
            modelBuilder.ApplyConfiguration(new RentaConfiguration());
            modelBuilder.ApplyConfiguration(new SolicitudConfiguration());
            modelBuilder.ApplyConfiguration(new FacturaConfiguration());
            modelBuilder.ApplyConfiguration(new ReservaConfiguration());

        }
    }
}
