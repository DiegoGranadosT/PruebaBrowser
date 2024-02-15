using PruebaTBrowser.Models.EntiityBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTBrowser.Models.Entities
{
    public class Cliente : ClienteBase
    {
        public Empresa Empresa { get; set; }
        public Ciudad Ciudad { get; set; }
        public IList<Preferencia> Preferencias { get; set; }
        public IList<Solicitud> Solicitudes { get; set; }
    }
}
