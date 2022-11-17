using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {


        static int funcion1(int n)
        {
            int resultado;
            if (n == 0)
            {
                resultado = 1;

            }
            else
            {

                resultado = 0;
            }
            return resultado;
        }


        static void Main(string[] args)
        {


            int n = 0;
            int z;
            Console.WriteLine("ingrese un numero para determinar : ");
            n = int.Parse(Console.ReadLine());

            z = funcion1(n);
            Console.WriteLine(z);
            Console.ReadLine();


        }
    }
}
