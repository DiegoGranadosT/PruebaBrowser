using PruebaTBrowser.Models.EntiityBases;

namespace PruebaTBrowser.Models.Entities
{
    public class Factura : FacturaBase
    {
        public MedioPago MedioPago { get; set; }
        public IList<Reserva> Reservas { get; set; }
    }
}