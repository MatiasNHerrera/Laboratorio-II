using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clase_05.Entidades;

namespace ftmTempera
{
    public partial class frmTempera : Form
    {
        public frmTempera()
        {
            InitializeComponent();

            // Enum.GetValues(typeof(ConsoleColor)); //le pasamos un typeof porque se requiere del tipo de clase, no la clase en si.
            //inicializo los colores
            foreach (ConsoleColor c in Enum.GetValues(typeof(ConsoleColor)))
            {
                cboColor.Items.Add(c); //añado los colores a cada iteracion
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void cboColor_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Tempera nuevaTempera = new Tempera((ConsoleColor)this.cboColor.SelectedItem, txtMarca.Text, sbyte.Parse(txtCantidad.Text)); //creo instancia de tempera parciando
            this._miTempera += nuevaTempera;
            this.DialogResult = DialogResult.OK;

            
        }

        private Tempera _miTempera;

        public Tempera MiTempera
        {
            get { return _miTempera; }
        }

    }
}
