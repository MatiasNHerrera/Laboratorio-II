using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Entidades_Clase17
{
    public class Persona : Humano , ISerializableXml , ISerializableBinario
    {
        public string nombre;
        public string apellido;
        private string path;

        public Persona()
        {

        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public override string ToString()
        {
            return base.ToString() + "Nombre: " + this.nombre + "\nApellido: " + this.apellido + "\n";
        }

        public bool Serializar()
        {
            bool retorno = false;

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Persona));
                StreamWriter writer = new StreamWriter(this.path);
                serializer.Serialize(writer, this);
                retorno = true;
                writer.Close();
            }
            catch (Exception)
            {
                retorno = false;
            }

            return retorno;
        }

        public bool Deserializar()
        {
            bool retorno = false;
            Persona p = new Persona();
            try
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(Persona));
                StreamReader reader = new StreamReader(path);
                p = (Persona)deserializer.Deserialize(reader);
                Console.WriteLine(p.ToString());
                reader.Close();

            }
            catch (Exception e)
            {
                retorno = false;
            }

            return retorno;
        }

        public string Path
        {
            get
            {
                return this.path;
            }
            set
            {
                this.path = value;
            }
        }


    }
}
