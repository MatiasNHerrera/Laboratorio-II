using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.IO;

namespace FrmTest
{
    public partial class FrmTest : Form
    {
        public FrmTest()
        {
            InitializeComponent();

            foreach (int item in Enum.GetValues(typeof(TipoManejador)))
            {
                this.cboManejador.Items.Add((TipoManejador)item);
            }
        }

        private void FrmTest_Load(object sender, EventArgs e)
        {

        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            EmpleadoMejorado em = new EmpleadoMejorado();
            

            em.Nombre = this.txtNombre.Text;
            em.Legajo = int.Parse(this.txtLegajo.Text);

            if(cboManejador.SelectedItem is TipoManejador.Log)
            {
                em._delSueldo += new DelSueldo(this.GuardarLog);
            }
            else if(cboManejador.SelectedItem is TipoManejador.LimiteSueldo)
            {
                em._delSueldo += new DelSueldo(FrmTest.LimiteSueldoEmpleado);
            }
            else
            {
                em._delSueldo += new DelSueldo(FrmTest.LimiteSueldoEmpleado);
                em._delSueldo += new DelSueldo(this.GuardarLog);
            }

            em.Sueldo = float.Parse(this.txtSueldo.Text);
        }

        public void GuardarLog(EmpleadoMejorado e, EmpleadoSueldoArgs em)
        {
            StreamWriter writer = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"archivo.log",true);
            bool todoOk = false;

            try
            {
                writer.WriteLine(DateTime.Now);
                writer.WriteLine("Nombre: " + e.Nombre);
                writer.WriteLine("Legajo: " + e.Legajo);
                writer.WriteLine("Sueldo que se intento agregar: " + em.Sueldo);
                writer.WriteLine("\n");
                todoOk = true;
                MessageBox.Show("Se pudo guardar");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (todoOk)
                {
                    writer.Close();
                }
            }
        }

        public static void LimiteSueldoEmpleado(EmpleadoMejorado e, EmpleadoSueldoArgs f)
        {
            MessageBox.Show("El empleado: " + e.Nombre + " con legajo: " + e.Legajo + " se le quiso asignar el sueldo: " + f.Sueldo);
        }

    }
}
