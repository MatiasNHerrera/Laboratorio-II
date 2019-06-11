using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Entidades
{
    public class AccesoDatos
    {
        private SqlConnection _conexion;
        private SqlCommand _comando;

        public AccesoDatos()
        {
            this._conexion = new SqlConnection(Properties.Settings.Default.Conexion_bd); //string de conexion creado anteriormente
        }

        public List<Persona> TraerTodos()
        {
            List<Persona> listado = new List<Persona>();
            SqlDataReader reader;

            try
            {

                this._comando = new SqlCommand(); //necesita de un objeto conexion de forma activa

                this._comando.Connection = this._conexion; // establece el atributo el cual tiene la conexion

                this._comando.CommandType = CommandType.Text; //tipo de comando

                this._comando.CommandText = "SELECT id,nombre,apellido,edad FROM Padron.dbo.Personas";

                this._conexion.Open(); //es necesario establecer la conexion con el servidor

                reader = this._comando.ExecuteReader();

                while (reader.Read()) //lee por linea y lo guarda en si mismo, por eso creo un objeto tipo persona y paso los datos, cuando ya no hay mas datos devuelve false
                {
                    Persona p = new Persona((int)reader["id"], reader["nombre"].ToString(), reader["apellido"].ToString(), (int)reader["edad"]);
                    listado.Add(p);
                }

                this._conexion.Close();


            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


            return listado;
        }

        public bool AgregarPersona(Persona p)
        {
            bool retorno = false;

            try
            {
                this._comando = new SqlCommand(); //necesita de un objeto conexion de forma activa

                this._comando.Connection = this._conexion; // establece el atributo el cual tiene la conexion

                this._comando.CommandType = CommandType.Text; //tipo de comando
                this._comando.CommandText = "insert into Padron.dbo.Personas (nombre, apellido, edad) values ('" + p._nombre + "','" + p._apellido + "', " + p.edad.ToString() + ")";
                this._conexion.Open();

                if (this._comando.ExecuteNonQuery() > 0)
                {
                    retorno = true;
                }

            }
            catch(Exception e)
            {

            }

            this._conexion.Close();
            

            return retorno;
        }
    }
}
