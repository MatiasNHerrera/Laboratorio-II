using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.IO;

namespace TestConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado e = new Empleado();
            Program p = new Program();

            e.Nombre = "Matias";
            e.Legajo = 1;

            e._limiteSueldo += new DelegadoSueldo(LimiteSueldoEmpleado);
            
            e._limiteSueldo += new DelegadoSueldo(p.GuardarLog);
            
            e.Sueldo = 15000;

            Console.WriteLine(e.ToString());

            Console.ReadKey();
        }

        public static void LimiteSueldoEmpleado(Empleado e, float f)
        {
            Console.WriteLine("El empleado: " + e.Nombre + " con legajo: " + e.Legajo + " se le quiso asignar el sueldo: " + f);
        }

        public void GuardarLog(Empleado e, float f)
        {
            StreamWriter writer = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"archivo.log");
            bool todoOk = false;

            try
            {
                writer.WriteLine(DateTime.Now);
                writer.WriteLine("Nombre: " + e.Nombre);
                writer.WriteLine("Legajo: " + e.Legajo);
                writer.WriteLine("Sueldo que se intento agregar: " + f);
                todoOk = true;
                Console.WriteLine("Se pudo guardar");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(todoOk)
                {
                    writer.Close();
                }
            }
        }
    }
}
