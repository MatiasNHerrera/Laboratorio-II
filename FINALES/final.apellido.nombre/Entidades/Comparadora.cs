using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comparadora
    {
        public static bool GetElDelMedio(int uno, int dos, int tres, out int elDelMedio)
        {
            bool retorno = false;

            elDelMedio = 0;

            if(dos > uno && dos < tres || dos > tres && dos < uno)
            {
                elDelMedio = dos;
                retorno = true;
            }
            else if(uno > dos && uno < tres || uno > tres && uno < dos)
            {
                elDelMedio = uno;
            }
            else if(tres > uno && tres < dos || tres > dos && tres < uno)
            {
                elDelMedio = tres;
                retorno = true;
            }
            else
            {
                elDelMedio = 0;
            }

            return retorno;
        }
    }
}
