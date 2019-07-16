using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(ProdImpuesto))]

    public class Producto
    {
        public string Nombre;
        public int Stock;

        public Producto()
        {

        }

        public Producto(string nombre, int stock)
        {
            this.Nombre = nombre;
            this.Stock = stock;
        }

        public override string ToString()
        {
            return "Nombre: " + this.Nombre + " Stock: " + this.Stock + "\n";
        }
    }
}
