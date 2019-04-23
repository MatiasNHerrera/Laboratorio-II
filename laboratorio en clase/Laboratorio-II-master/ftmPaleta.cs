using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ftmTempera;
using clase_05.Entidades;

namespace ftmPaleta
{
    public partial class ftmPaleta : Form
    {
        Paleta NuevaInstanciaPaleta = 5; // creo la variable paleta donde colocar las temperas;

        public ftmPaleta()
        {
            InitializeComponent();

        }

        private void BtnMas_Click(object sender, EventArgs e)
        {
            frmTempera NuevaInstancia = new frmTempera(); // creo una instancia del form de tempera para que lo abra
            // creo una instancia de paleta
            NuevaInstancia.ShowDialog();

            NuevaInstanciaPaleta += NuevaInstancia.MiTempera; // agrega a la instancia paleta las temperas.

            
            foreach(Tempera t in NuevaInstanciaPaleta._MisTemperas)
            {
                if(NuevaInstancia.DialogResult == DialogResult.OK && t !=null)
                {
                    LstLista.Items.Add(Tempera.Mostrar(t)); //agrega a la list box los distintos campos del array con la informacion
                }
            }
        }
    }
}
