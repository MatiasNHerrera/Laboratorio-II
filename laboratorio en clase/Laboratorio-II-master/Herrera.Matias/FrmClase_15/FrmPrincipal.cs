using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FrmClase_15
{
  public partial class FrmPrincipal : Form
  {
    private string path;

    public FrmPrincipal()
    {
      InitializeComponent();

    }

    private void FrmPrincipal_Load(object sender, EventArgs e)
    {
      this.openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
      this.openFileDialog1.Title = "Buscador";
      this.openFileDialog1.FileName = "miArchivo.txt";
      this.openFileDialog1.DefaultExt = ".txt";
      this.openFileDialog1.AddExtension = true;
      this.openFileDialog1.Filter = "archivos txt (*.txt)|*.txt";
      this.openFileDialog1.Multiselect = true;
    }

    private void btnEnviar_Click(object sender, EventArgs e)
    {

      try
      {

        //AppDomain.CurrentDomain.BaseDirectory = pone el archivo donde esta el ejecutable
        //Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\miArchivo.txt" = coloca el directorios especiales
        if (path != null)
        {
          StreamWriter escritura = new StreamWriter(path, true); //el parametro append = si esta en true concateno, si esta en false sobreescribe el contenido
          escritura.Write(this.txtValor.Text);
          escritura.Close();
        }
        else
        {
          MessageBox.Show("Debe buscar una ubicacion primero");
        }
        
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
      
    }

    private void btnTraer_Click(object sender, EventArgs e)
    {

      try
      {
        //lectura.Read esto lee de a un caracter
        //lectura.ReadToEnd lee contenido completo y lo transforma en string
        //lectura.ReadLine lee cada linea del archivo
        //lectura.ReadToEnd retorna un valor que indica si se encuentra al final de la secuencia

        if (path != null)
        {
          StreamReader lectura = new StreamReader(path, true); //asterisco es para poner una sola barrita
          while (!lectura.EndOfStream)
          {
            this.lstVisor.Items.Clear();
            this.lstVisor.Items.Add(lectura.ReadLine());
          }

          lectura.Close();
        }
        else
        {
          MessageBox.Show("Debe buscar una ubicacion primero");
        }
      
        /*string l = "";

        while((l = lectura.ReadLine()) != null)
        {
          l += lectura.ReadLine();
        }

        this.lstVisor.Items.Add(l);

        no anda del todo bien
        */
       
      }
      catch(Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void btnBuscar_Click(object sender, EventArgs e)
    {
      try
      {

        if(this.openFileDialog1.ShowDialog() == DialogResult.OK) //preguntamos por el dialog result del open modal
        {
          this.path += this.openFileDialog1.FileName; // retorna el lugar el cual marcamos
          MessageBox.Show(this.path);
        }
      }
      catch(Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
      
    }
  }
}
