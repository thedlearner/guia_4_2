using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_4
{
    internal class Program
    {
        static int leer(int n /*cantidad de numeros a sumar*/, int suma /* operacion de sumar numeros*/, int nu /* sumatoria de numeros */)
        {

            Console.WriteLine("ingrese los numeros :");
            for (int i = 0; i < n; i++)
            {

                nu = int.Parse(Console.ReadLine());


                suma = suma + nu;

            }

            return suma;
        }


        static void Main(string[] args)
        {
            {
                int n = 0;
                int nu = 0;
                int suma = 0;
                int z;
                Console.WriteLine("ingrese la cantidad de numeros a sumar :");
                n = int.Parse(Console.ReadLine());

                z = leer(n, nu, suma);

                Console.Write(z);
                Console.ReadLine();
            }














        }
    }
}
