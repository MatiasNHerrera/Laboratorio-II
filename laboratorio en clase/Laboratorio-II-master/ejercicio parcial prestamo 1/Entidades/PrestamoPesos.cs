using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    namespace PrestamosPersonales
    {
        public class PrestamoPesos : Prestamo
        {
            private float porcentajeInteres;


            public float MiInteres
            {
                get { return this.CalcularInteres(); }
            }


            public PrestamoPesos(float monto, DateTime vencimiento, float porcentajeInteres) : base(monto, vencimiento)
            {
                this.porcentajeInteres = porcentajeInteres;
            }

            public PrestamoPesos(PrestamoPesos prestamo, float porcentajeInteres) : this(prestamo._monto, prestamo._vencimiento, porcentajeInteres)
            {

            }

            private float CalcularInteres()
            {
                return base._monto * this.porcentajeInteres / 100;
            }

            public override void ExtenderPlazo(DateTime nuevoVencimiento)
            {
                TimeSpan diasAgregadors = nuevoVencimiento - base._vencimiento;
                int diferenciaDeDias = diasAgregadors.Days;
                float porcentajeAgregar = 0;

                porcentajeAgregar = float.Parse((diferenciaDeDias * 0.25).ToString());

                this.porcentajeInteres += porcentajeAgregar;

                base._vencimiento = nuevoVencimiento;

            }

            public string Mostrar()
            {
                StringBuilder sb = new StringBuilder();

                sb.Append(base.Mostrar());
                sb.Append(this.porcentajeInteres + " - ");
                sb.Append("Interes: " + this.MiInteres + "\n");

                return sb.ToString();
            }


        }
    }
}
