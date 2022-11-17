using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {

        static int funcion1(int x, int y, int z)
        {
            int resultado;

            resultado = x + y + z;

            return resultado;

        }
        static int funcion2(int x, int y, int z)
        {

            int resultado;
            resultado = 3 * x + 5 * y + z * z;
            return resultado;

        }


        static void Main(string[] args)
        {

            int x = 0;
            int y = 0;
            int z = 0;
            int op = 0;

            Console.WriteLine("##################################");
            Console.WriteLine("ingrese los numeros para la operacion ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Ingrese la funcion que quiera realizar ");
            Console.WriteLine("1.X+Y+Z= ");
            Console.WriteLine("2.3X+5Y*Z^2");





            op = int.Parse(Console.ReadLine());

            Console.Clear();
            if (op == 1)
            {
                z = funcion1(x, y, z);

                Console.Write(z);

            }
            else
            {

                z = funcion2(x, y, z);
                Console.Write(z);
            }

            Console.ReadKey();



        }
    }
}
