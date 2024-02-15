using PruebaTBrowser.Models.Base;
using PruebaTBrowser.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTBrowser.Models.EntiityBases
{
    public class FacturaBase : EntityBase<int>
    {
        public DateTime Fecha { get; set; }
        public int MedioPagoId { get; set; }
        public float Valor { get; set; }
    }
}
