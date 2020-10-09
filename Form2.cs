using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio1_Windows_AguilarNeil
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lstOperaciones.Items.Clear();
            lstOperaciones.Items.Add("Suma");
            lstOperaciones.Items.Add("Resta");
            lstOperaciones.Items.Add("Multiplicacion");
            lstOperaciones.Items.Add("Division");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double resultado,a,b;            
            a = Convert.ToDouble(txtbox1.Text);
            b = Convert.ToDouble(txtbox2.Text);
            //txtboxResultado.Text = (Convert.ToDouble(txtbox1.Text) + Convert.ToDouble(txtbox2.Text)).ToString();

            if (lstOperaciones.SelectedItem.ToString().Equals("Suma"))
            {
                resultado = a + b;
                txtboxResultado.Text = resultado.ToString();
            }
            else if (lstOperaciones.SelectedItem.ToString().Equals("Resta"))
            {
                resultado = a - b;
                txtboxResultado.Text = resultado.ToString();
            }
            else if (lstOperaciones.SelectedItem.ToString().Equals("Multiplicacion"))
            {
                resultado = a * b;
                txtboxResultado.Text = resultado.ToString();
            }
            else if (lstOperaciones.SelectedItem.ToString().Equals("Division"))
            {
                if (b != 0)
                {
                    resultado = a / b;
                    txtboxResultado.Text = resultado.ToString();
                }
                else MessageBox.Show("El valor 2 debe ser diferente de 0");              
            }          
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtbox1.Text = "";
            txtbox2.Text = "";
            txtboxResultado.Text = "";
        }

        private void lstOperaciones_Click(object sender, EventArgs e)
        {
            btnCalcular.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lstOperaciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtboxResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
