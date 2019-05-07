using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    namespace PrestamosPersonales
    {
        namespace EntidadFinanciera
        {
            public class Financiera
            {
                private List<Prestamo> listaDePrestamos;
                private string razonSocial;

                public string RazonSocial
                {
                    get { return this.razonSocial; }
                }

                public List<Prestamo> ListaDePrestamos
                {
                    get { return this.listaDePrestamos; }
                }

                public float InteresesDolar
                {
                    get { return CalcularInteresesGanados(ETipoDePrestamo.Dolares); }
                }

                public float InteresesPesos
                {
                    get { return CalcularInteresesGanados(ETipoDePrestamo.Pesos); }
                }

                public float InteresesTotales
                {
                    get { return CalcularInteresesGanados(ETipoDePrestamo.Todos); }
                }

                private Financiera()
                {
                    this.listaDePrestamos = new List<Prestamo>();
                }

                public Financiera(string razonSocial) : this()
                {
                    this.razonSocial = razonSocial;
                }

                private float CalcularInteresesGanados(ETipoDePrestamo tipoPresta)
                {
                    float retorno = 0;

                    foreach(Prestamo ptm in this.listaDePrestamos)
                    {
                        if(tipoPresta == ETipoDePrestamo.Dolares && ptm is PrestamoDolar)
                        {
                            retorno += ((PrestamoDolar)ptm).ElInteres;
                        }
                        else if(tipoPresta == ETipoDePrestamo.Pesos && ptm is PrestamoPesos)
                        {
                            retorno += ((PrestamoPesos)ptm).MiInteres;
                        }
                        else if(tipoPresta == ETipoDePrestamo.Todos)
                        {
                            if(ptm is PrestamoDolar)
                            {
                                retorno += ((PrestamoDolar)ptm).ElInteres;
                            }
                            else
                            {
                                retorno += ((PrestamoPesos)ptm).MiInteres;
                            }
                        }
                        
                    }

                    return retorno;
                    
                }

                public static bool operator ==(Financiera fn, Prestamo ptm)
                {
                    bool retorno = false;

                    foreach(Prestamo p in fn.listaDePrestamos)
                    {
                        if(p.ElMonto == ptm.ElMonto && p.ElVencimiento == ptm.ElVencimiento)
                        {
                            retorno = true;
                        }
                    }

                    return retorno;
                }

                public static bool operator !=(Financiera fn, Prestamo ptm)
                {
                    return !(fn == ptm);
                }

                public static Financiera operator +(Financiera fn, Prestamo ptm)
                {
                    if(!(fn == ptm))
                    {
                        fn.listaDePrestamos.Add(ptm);
                    }
                    else
                    {
                        Console.WriteLine("No puedo agregarse, ya se realizo este prestamo");
                    }

                    return fn;
                }

                public static explicit operator string(Financiera fn)
                {
                    StringBuilder sb = new StringBuilder();

                    sb.Append("\nIntereses Dolar: " + fn.InteresesDolar + "\n");
                    sb.Append("Intereses Pesos: " + fn.InteresesPesos + "\n");
                    sb.Append("Intereses Totales: " + fn.InteresesTotales + "\n\n");

                    foreach(Prestamo ptm in fn.listaDePrestamos)
                    {
                        if(ptm is PrestamoDolar)
                        {
                            sb.Append(((PrestamoDolar)ptm).Mostrar());
                        }
                        else
                        {
                            sb.Append(((PrestamoPesos)ptm).Mostrar());
                        }
                    }

                    return sb.ToString();
                }

                public static string Mostrar(Financiera fn)
                {
                    return (String)fn;
                }

                public void OrdenarPorFecha()
                {
                   
                }

            }
        }
    }
}
