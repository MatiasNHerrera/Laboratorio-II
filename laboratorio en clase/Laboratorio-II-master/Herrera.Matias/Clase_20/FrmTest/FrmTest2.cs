using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmTest
{
    public partial class FrmTest2 : Form
    {
        public FrmTest2()
        {
            InitializeComponent();
            this.Load += new EventHandler(inicializar);
        }

        private void inicializar(object sender, EventArgs e)
        {
            this.btnBoton1.Click += new EventHandler(this.MiManejador);
             
        }

        public void MiManejador(object sender, EventArgs e)
        {
            MessageBox.Show("Fue ejecutado el button: " + ((Button)sender).Name);

            if (((Button)sender).Name == "btnBoton1")
            {
                this.btnBoton1.Click -= new EventHandler(this.MiManejador);
                this.btnBoton2.Click += new EventHandler(this.MiManejador);
            }
            else if(((Button)sender).Name == "btnBoton2")
            {
                this.btnBoton2.Click -= new EventHandler(this.MiManejador);
                this.btnBoton3.Click += new EventHandler(this.MiManejador);
            }
            else
            {
                this.btnBoton3.Click -= new EventHandler(this.MiManejador);
                this.btnBoton1.Click += new EventHandler(this.MiManejador);
            }
        }


        public static void Sumar(int a, int b)
        {
            a += b;

            MessageBox.Show("Resultado Suma: " + a);
        }

        public void Restar(int a, int b)
        {
            a -= b;
            MessageBox.Show("Resultado Resta: " + a);
        }

        public void multiplicar(int a, int b)
        {
            MessageBox.Show("Resultado multplicacion " + a * b);
        }

        public void OtraSuma(MiDelegado d, int a, int b)
        {
            d.Invoke(a, b);
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            MiDelegado delegado = new MiDelegado(Sumar); //le paso la direccion de memoria del metodo
            MiDelegado delegado2 = new MiDelegado(Restar); //le paso la direccion de memoria del metodo
            MiDelegado delegadoCombinado = (MiDelegado)Delegate.Combine(delegado,delegado2); //combino los metodos
            MiDelegado delegado4 = (MiDelegado)Delegate.Combine(delegadoCombinado, new MiDelegado(multiplicar));

            //MessageBox.Show(delegado2.Method.ToString());
            //MessageBox.Show(delegado2.Target.ToString());
            
            foreach(Delegate a in delegadoCombinado.GetInvocationList())
            {
                MessageBox.Show(a.Method.ToString());
            }

            delegado.Invoke(45, 50); //invoco al metodo de forma explicita
            delegado(55, 50); //invoco al metodo de forma implicita
            delegado2.Invoke(32, 31);
            delegadoCombinado.Invoke(45, 34); //Invoco al delegado combinado
            delegado4.Invoke(7, 9); //delegado combinado que suma resta y multiplica
            this.OtraSuma(Sumar, 54, 21);
        }
    }
}
