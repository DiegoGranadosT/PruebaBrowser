using PruebaTBrowser.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTBrowser.Models.EntiityBases
{
    public class RentaBase : EntityBase<int>
    {
        public int VehiculoId { get; set; }
        public float Valor { get; set; }
        public Periodo Periodo { get; set; }
    }

    public enum Periodo
    {
        Dia,
        Semanal,
        Mes,
        Trimestral,
        Semestral,
        Anual
    }
}
