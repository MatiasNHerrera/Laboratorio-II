using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]

    public class ProdVendido : ProdExport
    {
        public string cliente;

        public ProdVendido()
        {

        }

        public ProdVendido(ProdExport p, string cliente) : base(((ProdImpuesto)p), p.pais)
        {
            this.cliente = cliente;
        }
    }
}
