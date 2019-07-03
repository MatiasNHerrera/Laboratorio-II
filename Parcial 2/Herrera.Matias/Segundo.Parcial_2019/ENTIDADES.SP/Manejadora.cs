using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ENTIDADES.SP
{
    public class Manejadora
    {
        public void Manejador(object obj)
        {
            bool todoOk = false;
            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\manejadora.txt");

                writer.Write(obj.ToString());

                todoOk = true;
  
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
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
