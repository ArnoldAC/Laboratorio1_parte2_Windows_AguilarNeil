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
    public partial class FrmOperaciones2 : Form
    {
        public FrmOperaciones2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double resultado, a, b;
            a = Convert.ToDouble(txtbox1.Text);
            b = Convert.ToDouble(txtbox2.Text);
            //txtboxResultado.Text = (Convert.ToDouble(txtbox1.Text) + Convert.ToDouble(txtbox2.Text)).ToString();

            if (rbtnSuma.Checked==true)
            {
                resultado = a + b;
                txtboxResultado.Text = resultado.ToString();
            }
            else if (rbtnResta.Checked == true)
            {
                resultado = a - b;
                txtboxResultado.Text = resultado.ToString();
            }
            else if (rbtnMultiplicacion.Checked == true)
            {
                resultado = a * b;
                txtboxResultado.Text = resultado.ToString();
            }
            else if (rbtnDivision.Checked == true)
            {
                if (b != 0)
                {
                    resultado = a / b;
                    //txtboxResultado.Text = resultado.ToString();
                    txtboxResultado.Text = string.Format("{0:n2}", (Math.Truncate(resultado * 100) / 100));
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
    }
}
