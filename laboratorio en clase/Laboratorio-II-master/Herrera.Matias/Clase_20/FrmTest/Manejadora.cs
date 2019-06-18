using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrmTest;

namespace FrmTest
{
    public class Manejadora
    {

        public static void Manejador(object sender, EventArgs e)
        {
            MessageBox.Show("Estoy usando la clase estatica manejadora");
            
            if(sender is TextBox)
            {
                MessageBox.Show("Fue un text box");
            }
            else if(sender is Label)
            {
                MessageBox.Show("Fue un label");
            }
            else
            {
                MessageBox.Show("Fue un button");
            }
        }

        public void ManejadorZ(object sender, EventArgs e)
        {
            MessageBox.Show("Estoy en el metodo de instancia de la clase manejador");

            if (sender is TextBox)
            {
                MessageBox.Show("Fue un text box");
            }
            else if (sender is Label)
            {
                MessageBox.Show("Fue un label");
            }
            else
            {
                MessageBox.Show("Fue un button");
            }
        }

    }
}
