using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ftmPaleta
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true; //nos permite que el form pueda tener otros formulario
            this.WindowState = FormWindowState.Maximized;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ftmPaleta nuevaInstancia = new ftmPaleta();
            nuevaInstancia.MdiParent = this;
            nuevaInstancia.Show();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Desea salir del programa?","Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrincipal_FormClosing(sender, new FormClosingEventArgs(CloseReason.UserClosing , true)); //aviso antes de cerrar si este lo desea, si no quiere el programa sigue funcionando
        }
    }
}
