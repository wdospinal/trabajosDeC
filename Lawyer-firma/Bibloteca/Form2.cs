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
        ConexionTablaExpediente CB = new ConexionTablaExpediente();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //Boton Consultar
            CB.Number = txtNumber.Text;
            CB.consultar();
            cmbStatus.Text = CB.Status;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //boton Guardar
            CB.Number = txtNumber.Text;
            CB.StartDate  = txtStartDate.Text;
            CB.EndDate = txtEndDate.Text;
            CB.Status = cmbStatus.Text;
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
