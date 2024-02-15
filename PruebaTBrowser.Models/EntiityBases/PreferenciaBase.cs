using PruebaTBrowser.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTBrowser.Models.EntiityBases
{
    public class PreferenciaBase : EntityBase<int>
    {
        public string Valor { get; set; }
        public int ClienteId { get; set; }
    }
}
