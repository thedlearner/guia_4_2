using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia_4_ejercicio_2__
{
    internal class Program
    {
        static int negativo(int a)
        {
            int resultado;

            if (a < 0)
            {
                resultado = a;
                Console.WriteLine("su numero es negativo");
            }

            else
            {
                resultado = a;
                Console.WriteLine("su numero es positivo");
            }

            return resultado;
        }


        static void Main(string[] args)
        {

            int a = 0;
            int z = 0;

            Console.WriteLine("ingrese su numero");
            a = int.Parse(Console.ReadLine());

            z = negativo(a);

            Console.ReadKey();



















        }
    }
}
