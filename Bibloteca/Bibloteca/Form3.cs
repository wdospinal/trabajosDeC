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
    public partial class Form3 : Form
    {
        ConexionTablaLibro CB = new ConexionTablaLibro();
        public Form3()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //Boton Consultar
            CB.Id = txtId.Text;
            CB.consultar();
            txtTitulo.Text = CB.Titulo;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
           
            //boton Guardar
            CB.Id = txtId.Text;
            CB.Titulo = txtTitulo.Text;
            CB.Editorial = txtEditorial.Text;
            CB.DateEscrito = txtDateEscrito.Text;
            CB.DatePublicado  = txtDatePublicado.Text;
            CB.Autor = txtAutor.Text;
            CB.guardar();
        
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Boton salir
            CB.cerrar();
            this.Close();
        }

        

        
    }
}
