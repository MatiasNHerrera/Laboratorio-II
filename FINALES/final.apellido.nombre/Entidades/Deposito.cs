using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;

namespace Entidades
{
    [Serializable]

    public class Deposito : IGuardarXml
    {
        protected string nombre;
        public List<Producto> lista;
        protected int cantidadMaxima;


        public Deposito() : this("Ninguno", 3)
        {
            this.lista = new List<Producto>();
        }

        public Deposito(string nombre, int cantidad)
        {
            this.nombre = nombre;
            this.cantidadMaxima = cantidad;
        }

        public void Add(Producto p)
        {
            if (this.lista.Count <= 3)
            {
                this.lista.Add(p);
            }
            else
            {
                throw new CantidadMaximaException("Error, cantidad maxima superada");
            }
        }

        public static List<Producto> operator +(Deposito d1, Deposito d2)
        {
            List<Producto> lista = new List<Producto>();
            bool validacion = false; 

            foreach (Producto p in d1.lista)
            {
                lista.Add(p);
            }

            foreach(Producto p in d2.lista)
            {
                validacion = false;

                foreach(Producto pr in lista)
                {
                    if(p.Nombre == pr.Nombre)
                    {
                        pr.Stock += p.Stock;
                        validacion = true;
                    }
                }

                if(!validacion)
                {
                    lista.Add(p);
                }


            }

            return lista;
        }

        public bool SerializarXml()
        {
            bool retorno = false;
            StreamWriter w = null;

            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(Deposito));
                w = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\xml.xml", false);
                ser.Serialize(w, this);
                retorno = true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                if(retorno)
                {
                    w.Close();
                }
            }

            return retorno;
        }
    }
}
