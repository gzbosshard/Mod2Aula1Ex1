using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2Aula1Ex4
{
    public class Retangulo : Figura
    {
        public override string cor { get; set; }

        public double lado1;
        public double lado2;

        public override double Area()
        {
            return lado1 * lado2;
        }
    }
}
