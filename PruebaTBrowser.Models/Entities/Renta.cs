using PruebaTBrowser.Models.Base;
using PruebaTBrowser.Models.EntiityBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTBrowser.Models.Entities
{
    public class Renta : RentaBase
    {
        public Vehiculo Vehiculo { get; set; }
        public IList<Solicitud> Solicitudes { get; set; }
    }
}
