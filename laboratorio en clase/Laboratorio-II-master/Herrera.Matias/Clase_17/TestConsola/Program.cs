using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_Clase17;
using System.Xml.Serialization;
using System.IO; 

namespace TestConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Humano h = new Humano();
            Persona p = new Persona("Matias", "Herrera");
            Alumno a = new Alumno();
            Profesor pr = new Profesor();
            List<Humano> lista = new List<Humano>();

            a.nombre = "Matias";
            a.apellido = "Herrera";
            a.Dni = 42038513;
            a.Legajo = 7;

            pr.nombre = "Jose";
            pr.apellido = "Perez";
            pr.Dni =38543212;
            pr.Titulo = "El crack";

            lista.Add(p);
            lista.Add(a);
            lista.Add(pr);


            //Console.WriteLine("Profesor: \n {0}\n", pr.ToString());
            //Console.WriteLine("Alumno: \n {0}", a.ToString());

            /*if(SerializarAlumno(a))
            {
                Console.WriteLine("Creado Correctamente");
            }
            else
            {
                Console.WriteLine("No se pudo serializar");
            }

             Alumno al = new Alumno();

             al = DeserializarAlumno();

             if(al != null)
             {
                 Console.WriteLine("Se pudo");
                 Console.WriteLine(al.ToString());
             }
             else
             {
                 Console.WriteLine("No se pudo deserializar");
             }
             

            h.Dni = 42038513;

            if(SerializarHumano(h))
            {
                Console.WriteLine("Creado Correctamente");
            }
            else
            {
                Console.WriteLine("No se pudo serializar");
            }
            

            /*Humano h2 = new Humano();
            h2 = DeserializarHumano();

            if (h2 != null)
            {
                Console.WriteLine("Se pudo");
                Console.WriteLine(h2.ToString());
            }
            else
            {
                Console.WriteLine("No se pudo deserializar");
            }
            */


            /* if(SerializarHumano(pr))
             {
                 Console.WriteLine("Se pudo");
             }
             else
             {
                 Console.WriteLine("No se pudo");
             }
             */
            /*Profesor p2 = new Profesor();
            p2 = (Profesor)DeserializarHumano();

            if (p2 != null)
            {
                Console.WriteLine("Se pudo");
                Console.WriteLine(p2.ToString());
            }
            else
            {
                Console.WriteLine("No se pudo deserializar");
            }
            */
            /*if (SerializarLista(lista))
            {
                Console.WriteLine("Se pudo serializar");
            }
            else
            {
                Console.WriteLine("No se pudo serializar");
            }

            List<Humano> list2 = new List<Humano>();
            list2 = DeserializarLista();

            if (list2 != null)
            {
                Console.WriteLine("Se pudo");
                foreach (Humano h3 in list2)
                {
                    Console.WriteLine(h3.ToString());
                }
            }
            else
            {
                Console.WriteLine("No se pudo deserializar");
            }
            */
            

            Console.ReadKey();

        }

        public static bool SerializarAlumno(Alumno al)
        {
            bool retorno = false;

            try
            { 
                XmlSerializer serializer = new XmlSerializer(typeof(Alumno));
                StreamWriter writer = new StreamWriter(@"D:\VisualStudio\Laboratorio-II\laboratorio en clase\Laboratorio-II-master\Herrera.Matias\Clase_17\Alumno.xml");
                serializer.Serialize(writer, al);
                retorno = true;
                writer.Close();
            }
            catch(Exception)
            {
                retorno = false;
            }

            return retorno;


        }

        public static Alumno DeserializarAlumno()
        {
            Alumno a = new Alumno();

            try
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(Alumno));
                StreamReader reader = new StreamReader(@"D:\VisualStudio\Laboratorio-II\laboratorio en clase\Laboratorio-II-master\Herrera.Matias\Clase_17\Alumno.xml");
                a = (Alumno)deserializer.Deserialize(reader);

                reader.Close();
                
            }
            catch(Exception e)
            {
                a = null;
            }

            return a;
        }

        public static bool SerializarHumano(Humano h)
        {
            bool retorno = false;

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Humano));
                StreamWriter writer = new StreamWriter(@"D:\VisualStudio\Laboratorio-II\laboratorio en clase\Laboratorio-II-master\Herrera.Matias\Clase_17\Humanos.xml");
                serializer.Serialize(writer, h);
                retorno = true;
                writer.Close();
            }
            catch (Exception)
            {
                retorno = false;
            }

            return retorno;


        }

        public static Humano DeserializarHumano()
        {
            Humano a = new Humano();

            try
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(Humano));
                StreamReader reader = new StreamReader(@"D:\VisualStudio\Laboratorio-II\laboratorio en clase\Laboratorio-II-master\Herrera.Matias\Clase_17\Profesor.xml");
                a = (Humano)deserializer.Deserialize(reader);

                reader.Close();

            }
            catch (Exception e)
            {
                a = null;
            }

            return a;
        }

        public static bool SerializarLista(List<Humano> lista)
        {
            bool retorno = false;

            try
            {

                XmlSerializer serializer = new XmlSerializer(typeof(List<Humano>));
                StreamWriter writer = new StreamWriter(@"D:\VisualStudio\Laboratorio-II\laboratorio en clase\Laboratorio-II-master\Herrera.Matias\Clase_17\Lista.xml");
                serializer.Serialize(writer, lista);
                retorno = true;
                writer.Close();
            }
            catch (Exception)
            {
                retorno = false;
            }

            return retorno;
        }

        public static List<Humano> DeserializarLista()
        {
            List<Humano> lista = new List<Humano>();

            try
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<Humano>));
                StreamReader reader = new StreamReader(@"D:\VisualStudio\Laboratorio-II\laboratorio en clase\Laboratorio-II-master\Herrera.Matias\Clase_17\Lista.xml");
                lista = (List<Humano>)deserializer.Deserialize(reader);

                reader.Close();

            }
            catch (Exception e)
            {
                lista = null;
            }

            return lista;
        }

        public static bool SerializarXML(ISerializableXml o)
        {
            bool retorno = false;

            if(o.Serializar())
            {
                retorno = true;
            }
            else
            {
                retorno = false;
            }

            return retorno;
        }
    }
}
