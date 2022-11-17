using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia_4_ejercicio_4__
{
    internal class Program
    {
        static int ecuacion1 (int x, int y, int z)
        {
            int resultado;
            resultado = x + y + z;
            return resultado;
        }

        static int ecuacion2(int x, int y, int z)
        {
            int resultado;
            resultado = (3 * x) + (5 * y) + (z*z);
            return resultado;
        }


        static void Main(string[] args)
        {
            int x = 0, y = 0, z = 0, v = 0, op = 0;

            Console.WriteLine("ingrese los valores de las incognitas");

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese la ecuacion que quiere resolver");

            op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                v = ecuacion1(x, y, z);
                Console.WriteLine("el resultado es " + v);
            }

            else

            {
                v = ecuacion2(x, y, z);
                Console.WriteLine("el resultado es " + v);
            }

            Console.ReadKey();

        }
    }
}
