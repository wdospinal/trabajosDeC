using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Bibloteca
{
    class ConexionTablaUsuario
    {
        private string id;
        private string direccion;
        private string celular;
        private string nombre;
        private string apellido;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        private SqlConnection con; //configurar  conexion BD
        private SqlCommand cmd; //configurar la cadena SQL
        private SqlDataReader Dato; //Configurar los registros resultantes,por medio de sentencia Select
        private string datosConexion;


        public ConexionTablaUsuario()
        {
            try
            {
               datosConexion = "Data Source = SALAK406-17;Initial Catalog = Fonda ; Integrated Security = true;";
               con = new SqlConnection();
               cmd = new SqlCommand();
               con.ConnectionString = datosConexion;
               con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                con.Close();
            }
        }




        public void guardar()
        {
            String textoCmd;
            try
            {
                textoCmd = "Insert into Usuario values('" + id + "','" + direccion + "','" + celular + "','" + nombre + "','" + apellido + "')";
                cmd.CommandText = textoCmd;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Su registro a sido guardado con exito");
            }
            catch (Exception e)
            {
                 MessageBox.Show("Error: " + e.Message);
            }
        }

        public void consultar()
        {
            String textoCmd;
            try
            {
                textoCmd = "select nombre from Usuario Where id ='" + id + "'";
                cmd.CommandText = textoCmd;
                cmd.Connection = con;
                Dato = cmd.ExecuteReader();
                if (Dato.Read())
                {
                    nombre = Convert.ToString(Dato.GetValue(0));
                    MessageBox.Show("El nombre del cliente " + nombre);
                    Dato.Close();
                }
                else
                {
                    MessageBox.Show("No existe datos");
                    Dato.Close();
                }
            }
            catch (Exception e)
            {

                 MessageBox.Show("Error: " + e.Message);
            }
        }

        public void cerrar()
        {
            try
            {
                con.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show("Error: " + e.Message);
            }
        }

    }
}
