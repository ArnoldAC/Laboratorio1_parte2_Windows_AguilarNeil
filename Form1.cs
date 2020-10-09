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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtbox1.Text = "";
            txtbox2.Text = "";
            txtboxResultado.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //double a, b;
            //a = convert.todouble(txtbox1.text);
            //b = convert.todouble(txtbox2.text);
            txtboxResultado.Text = (Convert.ToDouble(txtbox1.Text) + Convert.ToDouble(txtbox2.Text)).ToString();
        }
    }
}
