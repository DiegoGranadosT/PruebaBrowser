using PruebaTBrowser.Models.EntiityBases;

namespace PruebaTBrowser.Models.Entities
{
    public class MedioPago : MedioPagoBase
    {
        public IList<Factura> Facturas { get; set; }
    }
}