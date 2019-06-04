using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Clase17
{
    public interface ISerializableXml
    {
        bool Serializar();
        bool Deserializar();


        string Path
        {
            get;
            set;
        }


    }
}
