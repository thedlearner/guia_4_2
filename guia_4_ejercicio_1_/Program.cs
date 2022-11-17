using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia_4_ejercicio_1_
{
    internal class Program
    {
        /*
        
        static int sumar (int a, int b)
        {
        int resultado;
        resultado = a + b;
        return resultado;
        }

        static int restar (int a, int b)
        {
        int resultado;
        resultado = a-b;
        return resultado;
        }

        static void Main(string[] args)
        {
        int a = 0;
        int b = 0;
        int op = 0;

        Console.WriteLine("ingrese el numero de operacion a realizar");
        Console.WriteLine("1.sumar ; 2.restar);

        op=int.Parse(Console.ReadLine());

        if (op == 1)
        {
        z = sumar (a,b);
        Console.WriteLine("el resultado es:" + z);
        }

        else
        {
        z = restar(a,b);
        Console.WriteLine("el resultado es:" + z);
        }

        Console.ReadKey();
        
        */



        static int sumar(int a, int b)
        {
            int resultado;
            resultado = a + b;
            return resultado;
        }

        static int resta(int a, int b)
        {
            int resultado;
            resultado = a - b;
            return resultado;
        }

        static int multiplicar(int a, int b)
        {
            int resultado;
            resultado = a * b;
            return resultado;
        }

        static int dividir(int a, int b)
        {
            int resultado;
            resultado = a / b;
            return resultado;
        }



        static void Main(string[] args)
        {
            int a = 0;

            int b = 0;

            int z = 0;

            /* agregamos variable op para agregar opcion funcion a ejecutar*/
            int op = 0;

            Console.WriteLine("ingrese dos numeros");

            a = int.Parse(Console.ReadLine());

            b = int.Parse(Console.ReadLine());

            /* condicionamos a que los numeros a ingresar deben ser distintos de 0*/
            if (a != 0 && b != 0)
            {

                Console.WriteLine("Ingrese el numero de operacion a ejecutar");
                Console.WriteLine("1.sumar 2.restar 3. multiplicar 4.dividir");
                op = int.Parse(Console.ReadLine());

                if (op == 1)
                {

                    z = sumar(a, b);
                    Console.WriteLine(z);

                }

                else
                {
                    if (op == 2)
                    {

                        z = resta(a, b);
                        Console.WriteLine(z);

                    }
                    else
                    {
                        if (op == 3)
                        {

                            z = multiplicar(a, b);
                            Console.WriteLine(z);

                        }
                        else
                        {
                            if (op == 4)
                            {

                                z = dividir(a, b);
                                Console.WriteLine(z);

                            }

                        }

                    }


                }
            }
            
            /* si los numeros son igual a 0...*/
            else
            {

                Console.WriteLine("los numeros deben ser distintos de 0");

            }

        }


    }
}

