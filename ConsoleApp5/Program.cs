using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {


        static int negativo(int a)
        {
            int resultado;
            if (a < 0)
            {
                resultado = a;
                Console.Write("su numero  " + a + " es negativo");

            }
            else
            {
                resultado = a;
                Console.Write("su numero   " + a + "es postivo");

            }
            return resultado;

        }



        static void Main(string[] args)
        {
            int a = 0;
            int z;
            Console.WriteLine("ingrese el numero a determinar ");
            a = int.Parse(Console.ReadLine());

            z = negativo(a);

            Console.ReadKey();









        }
    }
}
