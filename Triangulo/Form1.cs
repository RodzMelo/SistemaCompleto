using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double b = double.Parse(txtBase.Text);
            double a = double.Parse(txtAltura.Text);

            CalculoTriangulo triangulo = new CalculoTriangulo();

            triangulo.Altura = a;
            triangulo.Base = b;

            lblResultado.Text = triangulo.CalcTriangulo().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double l = double.Parse(txtLado.Text);
            CalculoQuadrado quadrado = new CalculoQuadrado();

            quadrado.Lado = l;

            lblResultadoQuadrado.Text = quadrado.CalculaArea().ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
