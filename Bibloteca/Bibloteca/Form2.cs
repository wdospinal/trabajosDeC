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
    public partial class Form2 : Form
    {
        ConexionTablaUsuario CB = new ConexionTablaUsuario();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //Boton Consultar
            CB.Id = txtId.Text;
            CB.consultar();
            txtNombre.Text = CB.Nombre;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //boton Guardar
            CB.Id = txtId.Text;
            CB.Direccion = txtDireccion.Text;
            CB.Celular = txtCelular.Text;
            CB.Nombre = txtNombre.Text;
            CB.Apellido = txtApellido.Text;
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
