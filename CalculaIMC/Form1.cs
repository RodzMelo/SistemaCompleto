using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculaIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static double CalcIMC(double Peso, double Altura)
        {
            return Peso / (Altura * Altura);
        }

        public static string VerificaClassificacao(double IMC)
        {
            if (IMC < 16)
            {
                return "Magreza muito grave";
            }
            else if (IMC < 17)
            {
                return "Magreza moderada";
            }
            else if (IMC < 18.5)
            {
                return "Magreza leve";
            }
            else if (IMC < 25)
            {
                return "Você está saudável";
            }
            else if (IMC < 30)
            {
                return "Você está sobrepeso";
            }
            else
            {
                return "MUITO ACIMA DO PESO";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double imc = CalcIMC(double.Parse(txtPeso.Text), double.Parse(txtAltura.Text));

            lblResultado.Text = imc.ToString("F2");
            lblClassificacao.Text = VerificaClassificacao(imc);

            panel1.Visible = true;
        }

        private void lblResultadoImc_Click(object sender, EventArgs e)
        {

        }
    }
}
