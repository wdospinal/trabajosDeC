using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmSeguros
{
    public partial class Form1 : Form
    {
        #region "Atributos"

        private string Nombretitular, cedulaT;
        private string NombreBeneficiario, cedulaB;
        private string placa, marca, modelo, tipoV, tipoS, numeroP, cilindraje, color;
                
        private double dblVcomercial, dblVaccesorio, dblValorAsegurado;
        private double dblColpatria, dblSura, dblRsa;

        private double rc1, rc2, rc3, rcc1, rcc2, rcc3, pd1, pd2, pd3, ph1, ph2, ph3, t1, t2, t3, amit1, amit2, amit3;
        private double patri1, patri2, patri3, gdaño1, gdaño2, gdaño3, ghurto1, ghurto2, ghurto3, juri1, juri2, juri3, viaje1, viaje2, viaj3, con1,con2,con3;

        private double descuento, bonificacion, primabruta1, primabruta2, primabruta3, sub1,sub2,sub3;

        #endregion 

        #region "Constructor"
        public Form1()
        {
            InitializeComponent();
        }
        #endregion
        
        #region Propiedades


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            rc1=65000;
            rc2=75000;
            rc3 = 60000;

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            rcc1=80000;
            rcc2=120000;
            rcc3 = 105000;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            pd1=dblValorAsegurado*0.018;
            pd2= dblValorAsegurado* 0.04;
            pd3 = dblValorAsegurado* 0.02;

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            ph1=dblValorAsegurado* 0.027;
            ph2= dblValorAsegurado* 0.05;
            ph3 = dblValorAsegurado* 0.01;

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            t1 = dblValorAsegurado* 0.05;
            t2 = dblValorAsegurado* 0.05;
            t3 = dblValorAsegurado* 0.01;
                    }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            amit1 = dblValorAsegurado* 0.025;
            amit2 = dblValorAsegurado* 0.05;
            amit3 = dblValorAsegurado* 0.05;

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            patri1 = rc1 * 0.15 + pd1 * 0.15;
            patri2 = rc2 * 0.2 + pd2 * 0.2;
            patri3 = rc3 * 0.1 + pd3 * 0.1;

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            gdaño1 = pd1 * 0.2 + ph1 * 0.2;
            gdaño2 = ph2 * 0.085;
            gdaño3 = 0.125 * pd3;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            ghurto1 = 0.15 * pd1 + 0.15 * ph1;
            ghurto2 = 0.125 * ph2;
            ghurto3 = 0.125 * ph3;
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            juri1 = 0.075 * rc1 + 0.075 * pd1;
            juri2 = 0.05 * rc2 + 0.03 * pd2;
            juri3 = 0.05 * rc3 + 0.03 * pd3;
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            viaje1 = 0.1 * pd1 + 0.1 * ph1;
            viaje2 = 0.1 * pd2 + 0.05 * ph2;
            viaj3 = 0.05 * pd3 + 0.05 * ph3;


        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            con1 = 0.05 * rc1 + 0.01 * pd1 + 0.05 * pd2;
            con2 = 0.05 * rc2;
            con3 = 0.01 * rc3;

        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            sub1 = (primabruta1 * 1.08) * 1.16;
            sub2 = (primabruta2 * 1.08) * 1.16;
            sub3 = (primabruta3 * 1.08) * 1.16;
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            sub1 = (primabruta1 * 1.1) * 1.16;
            sub2 = (primabruta2 * 1.1) * 1.16;
            sub3 = (primabruta3 * 1.1) * 1.16;
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            sub1 = (primabruta1 - descuento) * 1.16;
            sub2 = (primabruta2 - descuento) * 1.16;
            sub3 = (primabruta3 - descuento) * 1.16;

        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            sub1 = (primabruta1 - descuento) * 1.16;
            sub2 = (primabruta2 - descuento) * 1.16;
            sub3 = (primabruta3 - descuento) * 1.16;
        }

        #endregion
        
        #region "Metodos"

        public void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Nombretitular = this.strNombreT.Text;
                NombreBeneficiario = this.strNombreB.Text;
                placa = this.strPlaca.Text;
                marca = this.strMarca.Text;
                modelo = this.strModelo.Text;
                tipoV = this.strTipo.Text;
                tipoS = this.strTservicio.Text;
                numeroP = this.strNpasajeros.Text;
                cilindraje = this.strCilindraje.Text;
                color = this.strColor.Text;
                dblVcomercial = (Convert.ToDouble(strValorComercial.Text));
                dblVaccesorio = (Convert.ToDouble(strValorAccesorios.Text));

                descuento = (Convert.ToDouble(strDscComercial.Text));
                bonificacion = (Convert.ToDouble(strBonificacion.Text));
               



            }
            catch (Exception excError)
            {

                MessageBox.Show("Error Datos invalidos:" + excError.Message);
                this.strNombreT.Focus();
                return;
            }

            dblValorAsegurado = dblVaccesorio + dblVcomercial;

            primabruta1 = (rc1 + rcc1 + pd1 + ph1 + t1 + amit1 + patri1 + gdaño1 + ghurto1 + juri1 + viaje1 + con1);
            primabruta2 = (rc2 + rcc2 + pd2 + ph2 + t2 + amit2 + patri2 + gdaño2 + ghurto2 + juri2 + viaje2 + con2);
            primabruta2 = (rc3 + rcc3 + pd3 + ph3 + t3 + amit3 + patri3 + gdaño3 + ghurto3 + juri3 + viaj3 + con3);

          this.strValorColpatria.Text=Convert.ToString(sub1);
          this.strValorSura.Text=Convert.ToString(sub2);
          this.strValorRsa.Text=Convert.ToString(sub3);


        }

        public void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void button3_Click(object sender, EventArgs e)
        {
            this.strNombreT.Text = string.Empty;
            this.strCedulaT.Text = string.Empty;
            this.strNombreB.Text = string.Empty;
            this.strCedulaT.Text = string.Empty;
            this.strPlaca.Text = string.Empty;
            this.strMarca.Text = string.Empty;
            this.strModelo.Text = string.Empty;
            this.strTipo.Text = string.Empty;
            this.strNpasajeros.Text = string.Empty;
            this.strCilindraje.Text = string.Empty;
            this.strColor.Text = string.Empty;
            this.strValorComercial.Text = string.Empty;
            this.strValorAccesorios.Text = string.Empty;
            this.strDscComercial.Text = string.Empty;
            this.strBonificacion.Text = string.Empty;
            this.strValorColpatria.Text = string.Empty;
            this.strValorSura.Text = string.Empty;
            this.strValorRsa.Text = string.Empty;

        }

      



        #endregion




        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

   

        
        

    }
}
