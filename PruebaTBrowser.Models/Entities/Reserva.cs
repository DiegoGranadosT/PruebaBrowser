using PruebaTBrowser.Models.Base;
using PruebaTBrowser.Models.EntiityBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTBrowser.Models.Entities
{
    public class Reserva : ReservaBase
    {
        public Solicitud Solucitud { get; set; }
        public Estado Estado { get; set; }
        public Factura Factura { get; set; }
    }
}
