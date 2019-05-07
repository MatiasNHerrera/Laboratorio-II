using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    namespace PrestamosPersonales
    {
        public class PrestamoDolar : Prestamo
        {
            private EPeriodicidadDePagos periocidad;

            public float ElInteres
            {
                get { return CalcularInteres(); }
            }

            public EPeriodicidadDePagos MiPeriocidad
            {
                get { return this.periocidad; }
            }


            private float CalcularInteres()
            {
                float retorno = 0;

                if (this.periocidad == EPeriodicidadDePagos.Mensual)
                {
                    retorno = base.ElMonto * 25 / 100;
                }
                else if (this.periocidad == EPeriodicidadDePagos.Bimestral)
                {
                    retorno = base.ElMonto * 35 / 100;
                }
                else
                {
                    retorno = base.ElMonto * 40 / 100;
                }

                return retorno;
            }

            public override void ExtenderPlazo(DateTime nuevoVencimiento)
            {
                TimeSpan diasAgregadors = nuevoVencimiento - base._vencimiento;
                int diferenciaDeDias = diasAgregadors.Days;

                base._monto += (float.Parse((diferenciaDeDias + 2.5).ToString()));

                base._vencimiento = nuevoVencimiento;
            }

            public PrestamoDolar(float monto, DateTime vencimiento, EPeriodicidadDePagos periocidad) : base(monto, vencimiento)
            {
                this.periocidad = periocidad;
            }

            public PrestamoDolar(Prestamo prestamo, EPeriodicidadDePagos periocidad) : this(prestamo.ElMonto, prestamo.ElVencimiento, periocidad)
            {

            }

            public string Mostrar()
            {
                StringBuilder sb = new StringBuilder();

                sb.Append(base.Mostrar());
                sb.Append(this.periocidad + " - ");
                sb.Append("Interes: " + this.ElInteres + "\n");

                return sb.ToString();
            }


        }
    }
}
