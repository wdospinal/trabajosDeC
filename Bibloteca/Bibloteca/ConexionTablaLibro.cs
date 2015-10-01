using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibloteca
{
    class ConexionTablaLibro
    {
        private string id;
        private string titulo;
        private string editorial;
        private string dateEscrito;
        private string datePublicado;
        private string autor;


        #region metodosAcceso
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public string Editorial
        {
            get { return editorial; }
            set { editorial = value; }
        }

        public string DateEscrito
        {
            get { return dateEscrito; }
            set { dateEscrito = value; }
        }
        public string DatePublicado
        {
            get { return datePublicado; }
            set { datePublicado = value; }
        }
        public string Autor
        {
          get { return autor; }
          set { autor = value; }
        }
        #endregion

        private SqlConnection con; //configurar  conexion BD
        private SqlCommand cmd; //configurar la cadena SQL
        private SqlDataReader Dato; //Configurar los registros resultantes,por medio de sentencia Select
        private string datosConexion;


        public ConexionTablaLibro()
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
                textoCmd = "Insert into Libro values('" + id + "','" + titulo + "','" + editorial + "','" + dateEscrito + "','" + datePublicado + "','" + autor + "')";
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
                textoCmd = "select titulo from Libro Where id ='" + id + "'";
                cmd.CommandText = textoCmd;
                cmd.Connection = con;
                Dato = cmd.ExecuteReader();
                if (Dato.Read())
                {
                    titulo = Convert.ToString(Dato.GetValue(0));
                    MessageBox.Show("El titulo del libro " + titulo);
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
