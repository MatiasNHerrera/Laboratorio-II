using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace ENTIDADES.SP
{
    public class Manzana : Fruta, ISerializar, IDeserializar
    {
        protected string _provinciaOrigen;

        public Manzana(string color, double peso, string origen ) : base(color, peso)
        {
            this._provinciaOrigen = origen;
        }

        public string Nombre
        {
            get
            {
                return "Manzana";
            }

        }

        public override string ToString()
        {
            return base.FrutaToString() + "Origen: " + this._provinciaOrigen;
        }

        public override bool TieneCarozo
        {
            get
            {
                return true;
            }
        }

        public bool Xml(string data)
        {
            bool retorno = false;

            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(Manzana));
                StreamWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + data);

                ser.Serialize(writer, this);
                writer.Close();
                retorno = true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            return retorno;
        }

        public bool Xml(string data, out Fruta fruta)
        {
            bool retono = false;
            fruta = null;

            try
            {
                XmlSerializer sr = new XmlSerializer(typeof(Manzana));
                StreamReader reader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + data);
                fruta = (Manzana)sr.Deserialize(reader);
                reader.Close();
                retono = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return retono;
        }
    }
}
