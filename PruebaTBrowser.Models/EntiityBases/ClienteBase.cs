using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTBrowser.Models.EntiityBases
{
    public class ClienteBase : PersonaBase
    {
        public int EmpresaId { get; set; }
        public int CiudadId { get; set; }
    }
}
