using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller4
{
    class Test
    {
        static void Main(string[] args)

        {
            var val = "y";
            while (val == "y"){

                Console.WriteLine("Seleccione que desea calcular: ");
                Console.WriteLine("1 - Area triangulo");
                Console.WriteLine("2 - Perimetro triangulo");
                Console.WriteLine("3 - Area circulo");
                Console.WriteLine("4 - Perimetro circulo");
                Console.WriteLine("5 - Area cubo");
                Console.WriteLine("6 - Perimetro cubo");

                var opcion = Console.ReadLine();


                switch (opcion)
                {
                    case "1":

                        Triangulo t = new Triangulo();

                        Console.WriteLine("Longitud del lado: ");
                        double lad;
                        double.TryParse(Console.ReadLine(), out lad);
                        t.Lado = lad;

                        Console.WriteLine("Longitud de la altura: ");
                        double alt;
                        double.TryParse(Console.ReadLine(), out alt);
                        t.Altura = alt;

                        Console.WriteLine(t.Area());
                        Console.WriteLine("Desea seguir? (Y para seguir)");

                        val = Console.ReadLine();

                        break;
                    case "2":
                        Triangulo t2 = new Triangulo();

                        Console.WriteLine("Longitud del lado: ");
                        double lad2;
                        double.TryParse(Console.ReadLine(), out lad2);
                        t2.Lado = lad2;


                        Console.WriteLine(t2.Perimetro());
                        Console.WriteLine("Desea seguir? (Y para seguir)");

                        val = Console.ReadLine();

                        break;
                    case "3":

                        Circulo c = new Circulo();

                        Console.WriteLine("Longitud del radio: ");
                        double rad;
                        double.TryParse(Console.ReadLine(), out rad);
                        c.Radio = rad;

                        Console.WriteLine(c.Area());
                        Console.WriteLine("Desea seguir? (Y para seguir)");

                        val = Console.ReadLine();

                        break;
                    case "4":
                        Circulo c2 = new Circulo();

                        Console.WriteLine("Longitud del radio: ");
                        double rad2;
                        double.TryParse(Console.ReadLine(), out rad2);
                        c2.Radio = rad2;

                        Console.WriteLine(c2.Perimetro());
                        Console.WriteLine("Desea seguir? (Y para seguir)");

                        val = Console.ReadLine();

                        break;
                    case "5":
                        Cubo c3 = new Cubo();

                        Console.WriteLine("Longitud del lado: ");
                        double ladc;
                        double.TryParse(Console.ReadLine(), out ladc);
                        c3.Lado = ladc;

                        Console.WriteLine(c3.Area());
                        Console.WriteLine("Desea seguir? (Y para seguir)");

                        val = Console.ReadLine();

                        break;
                    case "6":
                        Cubo c4 = new Cubo();

                        Console.WriteLine("Longitud del lado: ");
                        double ladc2;
                        double.TryParse(Console.ReadLine(), out ladc2);
                        c4.Lado = ladc2;

                        Console.WriteLine(c4.Perimetro());
                        Console.WriteLine("Desea seguir? (Y para seguir)");

                        val = Console.ReadLine();
                        break;
                    default:
                        Console.ReadKey();
                        break;

                }
            }
        }
        }
}
