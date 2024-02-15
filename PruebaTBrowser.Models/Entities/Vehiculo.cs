using PruebaTBrowser.Models.Base;
using PruebaTBrowser.Models.EntiityBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTBrowser.Models.Entities
{
    public class Vehiculo : VehiculoBase
    {
        public string Marca { get; set; }
        public string Refernecia { get; set; }
        public string Modelo { get; set; }
        public string Año { get; set; }
        public string Placa { get; set; }
        public IList<Renta> Rentas { get; set; }
    }
}
