using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioHerenciaWindowsForms
{
    public partial class Form1 : Form
    {
        //Atributo
        Piso p;
        Local l;

        private int auxAñoAntiguedad;

        private string auxDireccion ;

        private int auxEstadoInmueble = 0;

        private int auxMetrosCuadrados;

        private double auxPrecioBase;

        private int auxNumPiso;

        private int auxNumVentanas;

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtDireccion.Text = "";
            txtCantAños.Text = "0";
            txtCantVentanas.Text = "0";
            txtDireccion.Text = "";
            txtMetrosCuadrados.Text = "0";
            txtPiso.Text = "0";
            txtPrecioBase.Text = "0";
            lblPrecio.Text = "$0";

            if (rbtnPiso.Checked==true)
            {
                txtCantVentanas.Visible = false;
                txtCantVentanas.Text = "0";
                lblCantVentana.Enabled = false;
            }
            else
            {
                txtCantVentanas.Visible = true;
                lblCantVentana.Enabled = true;
            }
        }

        private void rbtLocal_CheckedChanged(object sender, EventArgs e)
        {
            txtDireccion.Text = "";
            txtCantAños.Text = "0";
            txtCantVentanas.Text = "0";
            txtDireccion.Text = "";
            txtMetrosCuadrados.Text = "0";
            txtPiso.Text = "0";
            txtPrecioBase.Text = "0";
            lblPrecio.Text = "$0";
            if (rbtLocal.Checked == true)
            {
                lblCantPisos.Enabled = false;
                txtPiso.Enabled = false;
                txtPiso.Text = "0";
            }               
            else
            {
                lblCantPisos.Enabled = true;
                txtPiso.Enabled = true;
            }
                
            
        }

        private void rbtnNuevo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNuevo.Checked == true)
            {
                lblCantAños.Enabled = false;
                txtCantAños.Enabled = false;
                txtCantAños.Text = "0";
            }
            else
            {
                lblCantAños.Enabled = true;
                txtCantAños.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            #region TRYCATCH de varaibles
            try
            {
                auxAñoAntiguedad = Convert.ToInt32(txtCantAños.Text);
            }
            catch
            {
                MessageBox.Show("Tipo de dato Erroneo. Revise el dato ingresado en el Campo Año de antiguedad","Error de dato");
            }

            try
            {
                auxDireccion = txtDireccion.Text;
            }
            catch
            {
                MessageBox.Show("Tipo de dato Erroneo. Revise el dato ingresado en el Campo Direccion", "Error de dato");
            }
            try
            {
                auxMetrosCuadrados = Convert.ToInt32(txtMetrosCuadrados.Text);
            }
            catch
            {
                MessageBox.Show("Tipo de dato Erroneo. Revise el dato ingresado en el Campo Metros Cuadrado", "Error de dato");
            }

            try
            {
                auxNumPiso = Convert.ToInt32(txtPiso.Text);
            }
            catch
            {
                MessageBox.Show("Tipo de dato Erroneo. Revise el dato ingresado en el Campo Pisos", "Error de dato");
            }
            try
            {
                auxPrecioBase = Convert.ToDouble(txtPrecioBase.Text);
            }
            catch
            {
                MessageBox.Show("Tipo de dato Erroneo. Revise el dato ingresado en el Campo PrecioBase", "Error de dato");
            }
            try
            {
                auxNumVentanas = Convert.ToInt32(txtCantVentanas.Text);
            }
            catch
            {
                MessageBox.Show("Tipo de dato Erroneo. Revise el dato ingresado en el Campo Cantidad Ventanas", "Error de dato");
            }

            auxEstadoInmueble = 0;
            #endregion



            if (rbtLocal.Checked == true)
            {
                l = new Local(auxAñoAntiguedad, auxDireccion, auxEstadoInmueble,auxMetrosCuadrados,auxPrecioBase,auxNumVentanas);
                lblPrecio.Text ="$"+Convert.ToString(l.calcularPrecio());
            }
            else
            {
                p = new Piso(auxAñoAntiguedad, auxDireccion, auxEstadoInmueble, auxMetrosCuadrados, auxPrecioBase, auxNumPiso);
                lblPrecio.Text="$"+Convert.ToString(p.calcularPrecio());
            }
        }
    }
}
