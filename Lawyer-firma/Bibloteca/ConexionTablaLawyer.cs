using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Bibloteca
{
    class ConexionTablaLawyer
    {
        private string document;
        private string name;
        private string address;
        private string phone;


        #region metodosAcceso
        public string Document
        {
            get { return document; }
            set { document = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        #endregion


        private SqlConnection con; //configurar  conexion BD
        private SqlCommand cmd; //configurar la cadena SQL
        private SqlDataReader Dato; //Configurar los registros resultantes,por medio de sentencia Select
        private string datosConexion;


        public ConexionTablaLawyer()
        {
            try
            {
                datosConexion = "Data Source = SALAK406-19;Initial Catalog = Fonda ; Integrated Security = true;";
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
                textoCmd = "Insert into Lawyer values('" + document + "','" + name + "','" + address + "','" + phone + "')";
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
                textoCmd = "select name from Lawyer Where document ='" + document + "'";
                cmd.CommandText = textoCmd;
                cmd.Connection = con;
                Dato = cmd.ExecuteReader();
                if (Dato.Read())
                {
                    name = Convert.ToString(Dato.GetValue(0));
                    MessageBox.Show("he name of lawyer is " + name);
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
