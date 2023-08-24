using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2Aula1Ex4
{
    internal class Triangulo : Figura
    {
        public override string cor { get; set; }

        public double baseT;
        public double altura;

        public override double Area()
        {
            return baseT * altura;
        }
    }
}
