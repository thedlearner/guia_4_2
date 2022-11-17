using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia_5_ejercicio_1_
{
    internal class Program
    {
        static int FuncionNumero (int a)
        {
            int resultado;
            
            if (a == 0)
            {
                resultado = 1;
                //Console.WriteLine("1");
            }

            else
            {
                resultado = 0;
                //Console.WriteLine("0");
            }

            return resultado;

        }

        
        static void Main(string[] args)
        {

            int a = 0, z = 0;

            Console.WriteLine("ingrese su numero");

            a = int.Parse(Console.ReadLine());

            z = FuncionNumero(a);

            Console.WriteLine(z);

            Console.ReadKey();
            
        }
    }
}
