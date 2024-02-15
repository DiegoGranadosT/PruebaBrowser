using PruebaTBrowser.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTBrowser.Models.EntiityBases
{
    public class ReservaBase : EntityBase<int>
    {
        public int SolucitudId { get; set; }
        public int EstadoId { get; set; }
        public int FacturaId { get; set; }
    }
}
