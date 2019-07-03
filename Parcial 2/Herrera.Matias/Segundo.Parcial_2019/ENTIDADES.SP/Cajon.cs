using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace ENTIDADES.SP
{
    public class Cajon<T> : ISerializar
    {
        protected int _capacidad;
        protected List<T> _elementos;
        protected double _precioUnitario;
        public event CajonLleno eventoPrecio;

        public List<T> Elementos
        {
            get
            {
                return this._elementos;
            }
        }

        public double PrecioTotal
        {
            get
            {
                double retorno = 0;

                if(this._precioUnitario * this._elementos.Count > 55)
                {
                    this.eventoPrecio(this);
                }
                else
                {
                    retorno = this._precioUnitario * this._elementos.Count;
                }

                return retorno;
            }
        }

        public Cajon()
        {
            this._elementos = new List<T>();
        }

        public Cajon(int capacidad) : this()
        {
            this._capacidad = capacidad;
        }

        public Cajon(double precioUnitario, int capacidad) : this(capacidad)
        {
            this._precioUnitario = precioUnitario;
        }

        public override string ToString()
        {
            string retorno = "";

            retorno += "Capacidad: " + this._capacidad + "\n";
            retorno += "Cantidad Elementos: " + this._elementos.Count + "\n";
            retorno += "Precio Unitario: " + this._precioUnitario + "\n";

            foreach (T elemento in this._elementos)
            {
                if (elemento != null)
                {
                    retorno += elemento.ToString();
                }
            }


            return retorno;
        }

        public static Cajon<T> operator +(Cajon<T> cajon, T item)
        {
            if(cajon._elementos.Count < cajon._capacidad)
            {
                cajon._elementos.Add(item);
            }
            else
            {
                throw new CajonLlenoException("\nEl cajon se encuentra lleno");
            }

            return cajon;
        }

        public bool Xml(string data)
        {
            bool retorno = false;

            try
            {
                XmlSerializer sr = new XmlSerializer(typeof(Cajon<T>));
                StreamWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + data);

                sr.Serialize(writer, this);
                writer.Close();
                retorno = true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            return retorno;
        }

    }

    public delegate void CajonLleno(object obj);

}
