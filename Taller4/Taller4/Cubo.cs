using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller4
{
    class Cubo : Figuras
    {
        public double Lado { get; set; }

        public override double Area()
        {
            return (Lado * Lado);
        }

        public override double Perimetro()
        {

            return (Lado*4f);

        }

    }
}
