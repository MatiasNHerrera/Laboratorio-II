﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Entidades;
using System.Threading;

//agregar libreria propia

namespace final.apellido.nombre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Apellido y nombre...");
        }

        //Realizar un método de extensión, llamado EsPar, para la clase Int32, que permita determinar si el número es par o no.
        //Crear otro método de extensión, llamado EsImpar, para la clase Int32, que determine si el número es impar o no.Reutilizar código.
        //Realizar un Test Unitario para verificar los métodos anteriores.
        private void button1_Click(object sender, EventArgs e)
        {
            int valor = 3;

            if (valor.esImpar())
            {
                MessageBox.Show("El " + valor + " es impar");
            }

            valor = 18;

            if (valor.esPar())
            {
                MessageBox.Show("El " + valor + " es par");
            }

        }

        //Crear en la clase Comparadora el método bool GetElDelMedio(int uno, int dos, int tres, out int elDelMedio). 
        //La funcionalidad de este método de clase es la siguiente: Retornará un true, si encuentra el valor medio entre 
        //los tres parámetros recibidos(y lo alojará en el parámetro de salida elDelMedio). Retornará false si no encuentra 
        //un valor medio.Ejemplo 1: uno = 6; dos = 9; tres = 8; => true; elDelMedio = 8. Ejemplo 2: uno = 5; dos = 1; 
        //tres = 5; => false; elDelMedio = 0
        //Hacer un Test Unitario para el ingreso de: 3, 5, 4;  5, 4, 4;  5, 1, 2; y  1, 1, 0.
        private void button2_Click(object sender, EventArgs e)
        {
            //3, 5, 4;  5, 4, 4;  5, 1, 2; y  1, 1, 0.
            int elDelMedio;
            if (Comparadora.GetElDelMedio(3, 5, 4, out elDelMedio))
            {
                MessageBox.Show("El del medio de entre\n 3, 5, 4 es: " + elDelMedio);
            }
            else
            {
                MessageBox.Show("No hay del medio de entre 3, 5, 4");
            }

            if (Comparadora.GetElDelMedio(5, 4, 4, out elDelMedio))
            {
                MessageBox.Show("El del medio de entre\n 5, 4, 4 es: " + elDelMedio);
            }
            else
            {
                MessageBox.Show("No hay del medio de entre 5, 4, 4");
            }

            if (Comparadora.GetElDelMedio(5, 1, 2, out elDelMedio))
            {
                MessageBox.Show("El del medio de entre\n 5, 1, 2 es: " + elDelMedio);
            }
            else
            {
                MessageBox.Show("No hay del medio de entre 5, 1, 2");
            }

            if (Comparadora.GetElDelMedio(1, 1, 0, out elDelMedio))
            {
                MessageBox.Show("El del medio de entre\n 1, 1, 0 es: " + elDelMedio);
            }
            else
            {
                MessageBox.Show("No hay del medio de entre 1, 1, 0");
            }

        }

        //Sabiendo que estas líneas de código son correctas, que los atributos de las clases son públicos y además que todas 
        //las clases poseen un solo constructor, realice los constructores, de cada una de las clases, sabiendo que 
        //ProdVendido hereda de ProdExport, que ProdExport hereda de ProdImpuesto y que éste último hereda de Producto.
        private void button3_Click(object sender, EventArgs e)
        {
            Producto pro = new Producto("Pala", 22);
            ProdImpuesto pI = new ProdImpuesto(pro.Nombre, pro.Stock, 600.33);
            ProdExport pEX = new ProdExport(pI, "Argentina");
            ProdVendido p = new ProdVendido(pEX, "Cliente Juan");

        }
        
        //Crear la clase Deposito que contenga nombre(protected; string) y productos(protected; lista genérica de tipo 
        //Producto), como atributos, y como método Add(agrega un elemento a la lista). 
        //a.Crear dos objetos de tipo Deposito(de 3 elementos de capacidad máxima, si la supera, lanza una excepción propia). 
        //La clase Producto tiene dos atributos: Nombre y Stock.
        //b.Se debe poder sumar los dos depósitos(con la sobrecarga de un operador en la clase Depósito) retornando 
        //una nueva lista con la suma de los Productos, (recordar que, si un producto está en las dos listas, se debe sumar 
        //el stock y no agregar dos veces al mismo producto).
        //c.Crear el “DepositoUno” con: 2 naranjas y 4 peras y el “DepositoDos” con: 2 peras, 2 manzanas, 5 naranjas y 
        //3 cerezas, mostrar el listado de productos resultantes con el método toString(), y el mensaje de la 
        //excepción propia(si se produjo).
        private void button4_Click(object sender, EventArgs e)
        {
            Deposito DepositoUno = new Deposito();
            Deposito DepositoDos = new Deposito();

            DepositoUno.Add(new Producto("naranja", 2));
            DepositoUno.Add(new Producto("pera", 4));

            DepositoDos.Add(new Producto("pera", 2));
            DepositoDos.Add(new Producto("manzana", 2));
            DepositoDos.Add(new Producto("naranja", 5));
   

            List<Producto> lista = DepositoUno + DepositoDos;
            string mensaje = "";

            foreach (Producto item in lista)
            {
                mensaje += item.ToString();
            }

            MessageBox.Show(mensaje);
            
        }

        //Diseñar la clase Numero que contendrá una propiedad "Cantidad" que sólo permita asignar un valor al atributo 
        //"_cantidad" y un evento EsImpar(diseñarlo para que reciba un Object y un EventArgs, su retorno será void). 
        //a.Si el valor que se intenta asignar es cero, se deberá lanzar una excepción de tipo ArgumentException, 
        //informando de lo acontecido.
        //Si el valor es par(utilizar lo hecho en el punto 1), dejar asignarlo.
        //Si el valor es impar (utilizar lo hecho en el punto 1) disparar el evento EsImpar cuyo manejador tendrá que 
        //escribir en un archivo de texto(log.txt) la fecha(hh:mm:ss y el valor) y dejar asignarlo.
        //b.Hacer un formulario con un cuadro de texto que reciba una cantidad y asignársela al objeto número, hacer 
        //el manejador de eventos en el formulario que capture el evento EsImpar cuyo manejador tendrá que escribir en un 
        //archivo de texto(log.txt) la fecha(hh:mm:ss y el valor) y asignarlo.
        //c.Realizar una estructura try-catch (por fuera de la propiedad) para la escritura de la propiedad del 
        //punto anterior que, al capturar la excepción, muestre el mensaje.
        private void button5_Click(object sender, EventArgs e)
        {
            
            Numero miNumero = new Numero();

            miNumero.EsImpar += new EventHandler(Manejadora);

            try
            {
                miNumero.Cantidad = 0;
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

            miNumero.Cantidad = 1;
            miNumero.Cantidad = 2;

        }

        //Realizar el burbujeo de una excepción propia, comenzando en un método de instancia, pasando por un 
        //método de estático y capturado por última vez en el manejador button6_Click.Mostrar por cada vez que es 
        //capturado (el lugar y método).
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Burbujeo.Estatica();
            }
            catch(ExceptionBurbujeo ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Crear la interface IGuardarXML { bool SerializarXML(); }. Implementarla en la clase Deposito.
        //La instancia de tipo Deposito tendrá, al menos, un objeto de tipo Producto, otro de tipo ProdImpuesto, 
        //otro de tipo ProdExport y otro de tipo ProdVendido) y generar una serialización XML del depósito.
        //Modificando lo que crea conveniente para poder serializar todos los atributos de todos los objetos intervinientes, 
        //guardando en el archivo archivo.xml.
        private void button7_Click(object sender, EventArgs e)
        {
        
            Deposito d = new Deposito();
            d.Add(new Producto("pera", 2));
            d.Add(new ProdImpuesto("cereza", 150, 600.33));
            d.Add(new ProdExport(new ProdImpuesto("banana", 16, 266), "Argentina"));
            d.Add(new ProdVendido(new ProdExport(new ProdImpuesto("maracuyá", 20, 666), "Brazil"), "Cliente Juan"));

            d.SerializarXml();
            
        }

        //Crear la clase genérica Cosa, utilizando una colección a elección, que exponga los métodos Add y Remove y la 
        //propiedad Count y un único constructor por defecto que inicialice la colección.
        private void button8_Click(object sender, EventArgs e)
        {
            Cosa<string> miCadena = new Cosa<string>();

            miCadena.Add("hola");
            miCadena.Add("mundo");
            MessageBox.Show(miCadena.Count.ToString());
            miCadena.Remove("hola");
            MessageBox.Show(miCadena.Count.ToString());

            Cosa<int> miNumero = new Cosa<int>();

            miNumero.Add(5);
            miNumero.Add(8);
            MessageBox.Show(miNumero.Count.ToString());
            miNumero.Remove(8);
            MessageBox.Show(miNumero.Count.ToString());

            Cosa<Producto> miProducto = new Cosa<Producto>();

            Producto p = new Producto("pera", 2);
            Producto p1 = new Producto("manzana", 8);

            miProducto.Add(p);
            miProducto.Add(p1);
            MessageBox.Show(miProducto.Count.ToString());
            miProducto.Remove(p);
            MessageBox.Show(miProducto.Count.ToString());
            

        }

        //Crear un método que retorne (en formato de string) el contenido de la tabla de la base de datos y
        //lo muestre en un MessageBox. Dicho método será invocado por un delegado adecuadamente diseñado.
        private void button9_Click(object sender, EventArgs e)
        {

        }

        //Crear un hilo que invoque a todos los manejadores de eventos (de los botones)
        private void button10_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(this.Eventos);
            t.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Manejadora(object sender, EventArgs args)
        {

            try
            {
                StreamWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\log.txt");

                writer.Write(DateTime.Now);

                writer.Close();

                MessageBox.Show("Se pudo escribir el archivo");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Eventos()
        {
            Thread.Sleep(1000);

            MessageBox.Show("Boton Uno: ");
            this.button1_Click(new object(), new EventArgs());

            MessageBox.Show("Boton Dos: ");
            this.button2_Click(new object(), new EventArgs());

            MessageBox.Show("Boton Tres: ");
            this.button3_Click(new object(), new EventArgs());

            MessageBox.Show("Boton Cuatro: ");
            this.button4_Click(new object(), new EventArgs());

            MessageBox.Show("Boton Cinco: ");
            this.button5_Click(new object(), new EventArgs());

            MessageBox.Show("Boton Seis: ");
            this.button6_Click(new object(), new EventArgs());

            MessageBox.Show("Boton Siete: ");
            this.button7_Click(new object(), new EventArgs());

            MessageBox.Show("Boton Ocho: ");
            this.button8_Click(new object(), new EventArgs());

            MessageBox.Show("Boton Nueve: ");
            this.button9_Click(new object(), new EventArgs());
        }
    }

    public delegate string SqlServer();
}
