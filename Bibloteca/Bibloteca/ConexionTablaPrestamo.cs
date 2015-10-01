using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Bibloteca
{
    class ConexionTablaPrestamo
    {
        /*
        Fecha prestamo
        Fecha maxima devolucion (15 dias)
        Fecha devolución
        ISBN_LIBRO
        ID_USUARIO
        */
        private string isbn;
        private string id_usuario;
        private string date_prestamo;
        private string date_devolucion;
        private string date_maxima;
        //encapsular campos


        private SqlConnection con; //configurar  conexion BD
        private SqlCommand cmd; //configurar la cadena SQL
        private SqlDataReader Dato; //Configurar los registros resultantes,por medio de sentencia Select
        private string datosConexion;

        public string Isbn
        {
            get
            {
                return isbn;
            }

            set
            {
                isbn = value;
            }
        }

        public string Id_usuario
        {
            get
            {
                return id_usuario;
            }

            set
            {
                id_usuario = value;
            }
        }

        public string Date_prestamo
        {
            get
            {
                return date_prestamo;
            }

            set
            {
                date_prestamo = value;
            }
        }

        public string Date_devolucion
        {
            get
            {
                return date_devolucion;
            }

            set
            {
                date_devolucion = value;
            }
        }

        public string Date_maxima
        {
            get
            {
                return date_maxima;
            }

            set
            {
                date_maxima = value;
            }
        }

        public ConexionTablaPrestamo()
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
                textoCmd = "Insert into Prestamo values('" + Isbn + "','" + Id_usuario + "','" + Date_prestamo + "','" + Date_devolucion + "','" + Date_maxima + "')";
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
                textoCmd = "select nombre from Prestamo Where isbn ='" + Isbn + "'";
                cmd.CommandText = textoCmd;
                cmd.Connection = con;
                Dato = cmd.ExecuteReader();
                if (Dato.Read())
                {
                    Id_usuario = Convert.ToString(Dato.GetValue(0));
                    MessageBox.Show("El id del cliente " + Id_usuario);
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
