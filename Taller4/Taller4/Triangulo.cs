using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller4
{
    class Triangulo : Figuras

    {
        //public Triangulo (double lado1, double lado2, double lado3){}


        public double Lado { get; set; }
        public double Altura { get; set; }

        public override double Area()
        {
            return (Lado * Altura) / 2f;
        }

        public override double Perimetro()
        {

            return (Lado * 3f);

        }
    }
}
