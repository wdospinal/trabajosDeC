﻿using System;
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
        ConexionTablaCustomer CB = new ConexionTablaCustomer();
        public Form3()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //Boton Consultar
            CB.Document= txtDocument.Text;
            CB.consultar();
            txtName.Text = CB.Name;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
           
            //boton Guardar
            CB.Document = txtDocument.Text;
            CB.Name = txtName.Text;
            CB.Address = txtAddress.Text;
            CB.Phone = txtPhone.Text;
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
