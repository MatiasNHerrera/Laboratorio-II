using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(ProdVendido))]

    public class ProdExport : ProdImpuesto
    {
        public string pais;

        public ProdExport()
        {

        }

        public ProdExport(ProdImpuesto p, string pais) : base(p.Nombre, p.Stock, p.impuesto)
        {
            this.pais = pais;
        }


    }
}
