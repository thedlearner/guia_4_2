using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        static String multiplos(int c)
        {
            String b = null;
            Console.Write("ingrese los numeros: ");
            c = int.Parse(Console.ReadLine());

            if (c % 5 == 0)
            {

                b = "si";

            }

            return b;

        }

        static void Main(string[] args)
        {
            int w = 0; // contador de multiplos de 5 
            int c = 0; // variable que recibe valor desde consola
            int x = 0; // variable que recibe cantidad de numeros a ingresar
            String j = null; // recibe valor desde funcion

            Console.Write("numeros a determinar: ");
            x = int.Parse(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {



                //llama a funcion
                j = multiplos(c);

                //evaluo el valor retornado desde la funcion
                if (j == "si")
                {
                    w++;
                }


            }
            Console.WriteLine("la cantidad de numeros multiplos de 5 son: " + w);
            Console.ReadLine();














        }
    }
}
