using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia_5_ejercicio_3__
{
    internal class Program
    {
        static int LeerNumeros(int CantidadNumeros, int SumarNumeros, int Suma)
        {
            for (int i = 0; i < CantidadNumeros; i++)
            {
            
                SumarNumeros = int.Parse(Console.ReadLine());

                Suma = Suma + SumarNumeros;
            
            }

            return Suma;
        }

        static void Main(string[] args)
        {
            int CantidadNumeros = 0, SumarNumeros = 0, Suma = 0, z = 0;

            Console.WriteLine("ingrese la cantidad de numeros");

            CantidadNumeros = int.Parse(Console.ReadLine());

            z = LeerNumeros(CantidadNumeros, SumarNumeros, Suma);

            Console.WriteLine(z);

            Console.ReadKey();

        }
    }
}
