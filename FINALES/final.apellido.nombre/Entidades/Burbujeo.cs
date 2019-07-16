using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Entidades
{
    public class Burbujeo
    {
        public void Instancia()
        {
            try
            {
                StreamWriter w = new StreamWriter("////archivo.txt");
            }
            catch(Exception e)
            {
                MessageBox.Show("Metodo de instancia");
                throw new ExceptionBurbujeo(e.Message);
            }
        }

        public static void Estatica()
        {
            Burbujeo b = new Burbujeo();

            try
            {
                b.Instancia();
            }
            catch(Exception)
            {
                MessageBox.Show("Metodo estatico");
                throw new ExceptionBurbujeo("Button 6");
            }
        }


    }
}
