using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {


        static double Mayor(double a, double b, double c)
        {
            double resultado;
            if (a > b && a > c)
            {

                resultado = a;
                Console.Write(" el numero  " + a + "  es el mayor de los tres ");

            }
            else
            {
                if (b > a && b > c)
                {
                    resultado = b;
                    Console.Write(" el numero  " + b + "  es el mayor de los tres ");


                }
                else
                {

                    resultado = c;
                    Console.Write(" el numero  " + c + "  es el mayor de los tres ");

                }



            }

            return resultado;
        }



        static void Main(string[] args)
        {
            double a = 0, b = 0, c = 0, z;

            Console.WriteLine("determinar cual de los tres numeros es el mayor");
            Console.WriteLine("******* ///////////// *******  ///////// *************");
            Console.WriteLine("ingrese los tres numeros");

            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            z = Mayor(a, b, c);

            Console.ReadLine();

        }
    }
}
