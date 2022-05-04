using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaIMC
{
    internal class CalculoDoIMC
    {
        private double Peso;
        private double Altura;

        public double Calcular()
        {
            return Peso / (Altura * Altura);
        }
        
        
    }
}
