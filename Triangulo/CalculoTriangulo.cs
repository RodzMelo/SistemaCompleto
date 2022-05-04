using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    internal class CalculoTriangulo
    {
       public double Base;
       public double Altura;

        public double CalcTriangulo()
        {
            return Base * Altura / 2;
        }
    }
}
