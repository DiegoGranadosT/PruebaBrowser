using PruebaTBrowser.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTBrowser.Models.EntiityBases
{
    public class VehiculoBase : EntityBase<int>
    {
        public string Marca { get; set; }
        public string Refernecia { get; set; }
        public string Modelo { get; set; }
        public string Año { get; set; }
        public string Placa { get; set; }
    }
}
