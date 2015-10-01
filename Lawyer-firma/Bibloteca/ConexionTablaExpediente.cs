using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Bibloteca
{
    class ConexionTablaExpediente
    {
        private string number;
        private string startDate;
        private string endDate;
        private string status;

        public string Number
        {
            get { return number; }
            set { number = value; }
        }
        
        public string StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        
        public string EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
        

        public string Status
        {
            get { return status; }
            set { status = value; }
        }


        private SqlConnection con; //configurar  conexion BD
        private SqlCommand cmd; //configurar la cadena SQL
        private SqlDataReader Dato; //Configurar los registros resultantes,por medio de sentencia Select
        private string datosConexion;


        public ConexionTablaExpediente()
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
                textoCmd = "Insert into Expedient values('" + number + "','" + startDate + "','" + endDate + "','" + status + "')";
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
                textoCmd = "select status from Expedient Where number ='" + number + "'";
                cmd.CommandText = textoCmd;
                cmd.Connection = con;
                Dato = cmd.ExecuteReader();
                if (Dato.Read())
                {
                    status = Convert.ToString(Dato.GetValue(0));
                    MessageBox.Show("Status of expedient " + status);
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
