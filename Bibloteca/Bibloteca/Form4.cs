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
            CB.Isbn = txtId.Text;
            CB.consultar();
            txtIdUsuario.Text = CB.Id_usuario;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //boton Guardar
            CB.Isbn = txtId.Text;
            CB.Id_usuario = txtIdUsuario.Text;
            CB.Date_prestamo = txtDatePrestamo.Text;
            CB.Date_devolucion = txtDateDevolucion.Text;
            CB.Date_maxima = txtDateMaxima.Text;
            CB.guardar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //Boton salir
            CB.cerrar();
            this.Close();
        }
    }
}
