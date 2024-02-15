using PruebaTBrowser.Models.Base;
using PruebaTBrowser.Models.EntiityBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTBrowser.Models.Entities
{
    public class Solicitud : SolicitudBase
    {
        public Renta Renta { get; set; }
        public Cliente Cliente { get; set; }

    }
}
