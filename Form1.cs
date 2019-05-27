using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clase_04Libreria;

namespace Clase4.WindowForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Cosa objForm = new Cosa();
            //MessageBox.Show(objForm.Mostrar())


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cosa objForm = new Cosa();

            this.button1.Text = "Crear cosita bonita";
            this.button1.ForeColor = Color.Red;
            this.button1.BackColor = Color.Yellow;
            MessageBox.Show(objForm.Mostrar());

        }
    }
}
