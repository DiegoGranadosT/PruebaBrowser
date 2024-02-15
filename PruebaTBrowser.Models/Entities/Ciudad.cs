using PruebaTBrowser.Models.EntiityBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTBrowser.Models.Entities
{
    public class Ciudad : CiudadBase
    {
        public Departamento Departamento { get; set; }
        public IList<Cliente> Clientes { get; set; }
    }

    public class Departamento : DepartamentoBase
    {
        public Pais Pais { get; set; }
        public IList<Ciudad> Ciudads { get; set; }
    }

    public class Pais : PaisBase
    {
        public IList<Departamento> Departamentos { get; set; }
    }
}
