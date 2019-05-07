using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    namespace PrestamosPersonales
    {
        public abstract class Prestamo
        {
            protected float _monto;
            protected DateTime _vencimiento;


            public float ElMonto
            {
                get { return this._monto; }
            }

            private DateTime _miVencimiento;

            public DateTime ElVencimiento
            {
                get { return _miVencimiento; }
                set
                {
                    if (_miVencimiento > DateTime.Now)
                    {
                        _miVencimiento = value;
                    }
                    else
                    {
                        _miVencimiento = DateTime.Now;
                    }
                }
            }

            public Prestamo(float monto, DateTime vencimiento)
            {
                this._monto = monto;
                this._vencimiento = vencimiento;
            }

            public static int OrdenarPorFecha(Prestamo ptm1, Prestamo ptm2)
            {
                int retorno = 0;

                if(ptm1._vencimiento > ptm2._vencimiento)
                {
                    retorno = 1;
                }
                else if(ptm1._vencimiento < ptm2._vencimiento)
                {
                    retorno = -1;
                }
                else
                {
                    retorno = 0;
                }

                return retorno;
            }

            public abstract void ExtenderPlazo(DateTime nuevoVencimiento);

            public virtual string Mostrar()
            {
                return "Monto: " + this._monto + " - " + this._vencimiento + " - ";
            }


        }
    }
}
