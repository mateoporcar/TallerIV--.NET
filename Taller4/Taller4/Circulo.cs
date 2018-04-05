using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller4
{
    class Circulo : Figuras
    {
        public double Radio { get; set; }

        public override double Area()
        {
            return (Math.PI * Radio*Radio);
        }

        public override double Perimetro()
        {

            return ((Math.PI * Radio + Radio));

        }
    }
}
