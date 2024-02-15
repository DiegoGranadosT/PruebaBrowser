using PruebaTBrowser.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTBrowser.Models.EntiityBases
{
    public class DepartamentoBase : EntityBase<int>
    {
        public string Nombre { get; set; }
        public int PaisId { get; set; }
    }
}
