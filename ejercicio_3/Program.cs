using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
    internal class Program
    {


        static int Impar(int a)
        {
            int resultado;
            if (a % 2 == 0)
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
            int a = 0;
            int z;

            Console.WriteLine("ingrese el numero a determinar ");
            a = int.Parse(Console.ReadLine());

            z = Impar(a);


            if (z == 1)
            {

                Console.WriteLine("es par");
            }
            else
            {
                Console.WriteLine("es Impar");

            }
            Console.ReadLine();









        }
    }
}
