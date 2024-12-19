using System;
using System.ComponentModel.Design;
using System.Globalization;
using TrianguloMelhorado;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;

                Triangulo x, y;

                y = new Triangulo();
                x = new Triangulo();

                Console.WriteLine("Entre com as medidas do trinago X: ");
                x.A = double.Parse(Console.ReadLine(), CI);
                x.B = double.Parse(Console.ReadLine(), CI);
                x.C = double.Parse(Console.ReadLine(), CI);

                Console.WriteLine("Entre com as medidas do trinago Y: ");
                y.A = double.Parse(Console.ReadLine(), CI);
                y.B = double.Parse(Console.ReadLine(), CI);
                y.C = double.Parse(Console.ReadLine(), CI);

                double p = (x.A + x.B + x.C) / 2.0;
                double Areax = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

                p = (y.A + y.B + y.C) / 2.0;
                double Areay = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

                Console.WriteLine("Área de x = " + Areax.ToString("F4", CI));
                Console.WriteLine("Área de y = " + Areay.ToString("F4", CI));

                if (Areax > Areay)
                {
                    Console.WriteLine("Maior área X: ");
                }
                else
                {
                    Console.WriteLine("Maior área y: ");
                }
            }
        }
    }
}