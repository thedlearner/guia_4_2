using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia_4_ejercicio_3__
{
    internal class Program
    {
        static double mayor(double a, double b, double c)
        {
            double resultado;

            if (a > b && a > c)
            {

                resultado = a;
                Console.WriteLine("el numero mayor sera " + a);

            }

            else
            {
                if (b > a && b > c)
                {

                    resultado = b;
                    Console.WriteLine("el numero mayor sera " + b);

                }

                else
                {

                    resultado = c;
                    Console.WriteLine("el numero mayor sera " + c);

                }

            }

            return resultado;

        }

            static void Main(string[] args)
            {
                double a = 0, b = 0, c = 0, z = 0;

                Console.WriteLine("ingrese sus numeros");

                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                c = double.Parse(Console.ReadLine());

                z = mayor(a, b, c);

                Console.ReadKey();

            }
    }
}

