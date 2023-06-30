using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaDia2
{
    internal class Campanha
    {
        public DateTime DataDeInicio { get; set; }
        public DateTime DataFim { get; set; }
        public Premio Premio { get; set; }
        public List<Vendedor> Vendedores { get; set; }

        public Campanha()
        {
            Vendedores = new List<Vendedor>();
        }
    }
}
