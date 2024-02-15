using PruebaTBrowser.Models.Base;
using PruebaTBrowser.Models.EntiityBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTBrowser.Models.Entities
{
    public class Empresa : EmpresaBase
    {
        public string Nombre { get; set; }
        public IList<Cliente> Clientes { get; set; }
    }
}
