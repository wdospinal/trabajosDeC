using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibloteca
{
    public partial class Form4 : Form
    {
        ConexionTablaPrestamo CB = new ConexionTablaPrestamo();
        public Form4()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //Boton Consultar
            CB.Isbn = txtIsb.Text;
            CB.consultar();
            txtIdUsuario.Text = CB.Id_Usuario;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
           
            //boton Guardar
            CB.Isbn = txtId.Text;
            CB.id_usuario = txtIdUsuario.Text;
            CB.date_prestamo = txtDatePrestamo.Text;
            CB.date_devolucion = txtDateDevolucion.Text;
                CB.date_maxima  = txtDateMaxima.Text;
            CB.guardar();
            /*
         private string isbn;
        private string id_usuario;
        private string date_prestamo;
        private string date_devolucion;
        private string date_maxima;*/
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Boton salir
            CB.cerrar();
            this.Close();
        }

        

        
    }
}