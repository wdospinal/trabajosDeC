using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMercado
{
    class ConexionBD
    {

        private string apellido;
        private string nombre;
        private double compra;

       

        private SqlConnection con; //configurar  conexion BD
        private SqlCommand cmd; //configurar la cadena SQL
        private SqlDataReader Dato; //Configurar los registros resultantes,por medio de sentencia Select
        private string datosConexion;


        public ConexionBD()
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


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Cedula
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public double Compra
        {
            get { return compra; }
            set { compra = value; }
        }

        public void guardar()
        {
            String textoCmd;
            try
            {
                textoCmd = "Insert into Cliente values('" + nombre + "','" + apellido + "','" + compra + "')";
                cmd.CommandText = textoCmd;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Su compra por " + compra + " a sido guardado con exito");
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
                textoCmd = "select valor from Cliente Where nombre ='" + nombre + "'";
                cmd.CommandText = textoCmd;
                cmd.Connection = con;
                Dato = cmd.ExecuteReader();
                if (Dato.Read())
                {
                    compra = Convert.ToInt32(Dato.GetValue(0));
                    MessageBox.Show("El valor de compra del cliente es:" + compra);
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


