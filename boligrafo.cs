using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boligrafo
{
    class boligrafo
    {
        const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;


        public boligrafo (short tinta, ConsoleColor color)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor getColor()
        {
            return this.color;
        }

        public short getTinta()
        {
            return this.tinta;
        }

        private void setTinta(short tinta)
        {
            if(tinta <= cantidadTintaMaxima && tinta > -100)
            {
                short auxTinta = this.tinta;
                auxTinta += tinta;

                if(auxTinta >= -100 && auxTinta <= cantidadTintaMaxima)
                {
                    this.tinta += tinta;
                }
                else
                {
                    Console.WriteLine("Error, la recarga de tinta se ha sobrepasado");
                }

            }

        }

        public void recargar()
        {
            short tintaRecargar;

            tintaRecargar = cantidadTintaMaxima;

            tintaRecargar -= tinta;

            setTinta(tintaRecargar);
        }

        public bool pintar(short gasto, out string dibujo)
        {
            bool sePudo;
            dibujo = "";

            setTinta(gasto);

            if (this.tinta > 0)
            {
                sePudo = true;
            }
            else
            {
                sePudo = false;
            }

            return sePudo;
        }

       
    }
}
