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
    public partial class FrmTest : Form
    {
        public FrmTest()
        {
            InitializeComponent();

            Manejadora m = new Manejadora();

            this.lblEtiqueta.Click += new System.EventHandler(Manejadora.Manejador);
            this.txtCuadroTexto.Click += new System.EventHandler(Manejadora.Manejador);
            this.btnBoton.Click += new System.EventHandler(Manejadora.Manejador);
            this.lblEtiqueta.Click += new System.EventHandler(m.ManejadorZ);
            this.txtCuadroTexto.Click += new System.EventHandler(m.ManejadorZ);
            this.btnBoton.Click += new System.EventHandler(m.ManejadorZ);
        }

        private void mostrarMensaje(object sender, EventArgs e) //Object: quien provoco el evento, EventArgs: 
        { 
            MessageBox.Show("Evento click del boton");
            //this.lblEtiqueta.Click += new System.EventHandler(this.lblEtiqueta_Click); //por cada click en mostrar, agrego una nueva direccion de memoria para la lista de invocacion del label.
            //this.txtCuadroTexto.Click += new System.EventHandler(this.txtCuadroTexto_Click);
        }

        private void lblEtiqueta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Evento click del label");
            //this.lblEtiqueta.Click -= new System.EventHandler(this.lblEtiqueta_Click); //quita los eventos agregados

        }

        private void txtCuadroTexto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Evento click del text");
        }




    }
}
