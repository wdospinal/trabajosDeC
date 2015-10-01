using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMercado
{
    public partial class Form1 : Form
    {

        ConexionBD CB = new ConexionBD();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            //boton Guardar
            CB.Nombre = txtNombre.Text;
            CB.Cedula = txtApellido.Text;
            CB.Compra = Convert.ToDouble(txtCompra.Text);
            descuento();
            CB.guardar();
        }



        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            //Boton Consultar
            CB.Nombre = txtNombre.Text;
            CB.consultar();
            txtCompra.Text = Convert.ToString(CB.Compra);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //Boton salir
            CB.cerrar();
            this.Close();
        }

        private void descuento()
        {
            if ( CB.Compra > 200000) {
                CB.Compra -=  CB.Compra * 0.3;
            }
            else
            {
                CB.Compra -= CB.Compra * 0.05;
            }
        }
      

        
    }
}
