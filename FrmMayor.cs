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
    public partial class FrmMayor : Form
    {
        public FrmMayor()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double resultado, a, b;

            a = Convert.ToDouble(txtbox1.Text);
            b = Convert.ToDouble(txtbox2.Text);

            if (a > b)
            {
                resultado = a;
                txtboxResultado.Text = resultado.ToString();
            }
            else
            {
                resultado = b;
                txtboxResultado.Text = resultado.ToString();
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtbox1.Text = "";
            txtbox2.Text = "";
            txtboxResultado.Text = "";
        }
    }
}
