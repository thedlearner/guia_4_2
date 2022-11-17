using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1
{
    internal class Program
    {
     
        /* declaramos una funcion con static, indicando el tipo de dato que retornara, lo asignamos a una variable y definimos los valores involucrados en la funcion junto con su tipo:
         static int nombre (int a, int b)
        luego, abrimos parentesis, indicamos la variable que retornara el resultado y su tipo, int resultado, luego definimos que hara la variable resultado, en este caso tomara los valores a y b y los sumara, resultado=a+b
        luego inicializamos la funcion return para que la funcion retorne el valor de la ejecuccion de la variable resultado.
        
         Una vez definida la funcion, programamos como se ingresaran los datos. esto en la funcion principal*/

         /* primero, indicamos los datos que estan involucrados. luego, abrimos Console.WriteLine("ingrese dos numeros") seguidos por la asignacion de lo que escriba el usuario mediante int.Parse(Console.ReadLine());
         * y asignamos a una variable via a = int.Parse(Console.ReadLine());
         
         Luego, un condicional if a es diferente de 0 y b diferente de 0 mediante if (a!=0 && b!=0), dejaremos al usuario ingresar un numero para seleccionar la operacion. para esto, definimos la variable OP que almacenara
        la respuesta via op= int.Parse(Console.ReadLine());
        
         Luego definimos if condicionales si OP==1, 2, 3 o 4
        
         En todos los condicionales usamos la funcion mediante la variable z que almacenara el resultado de la funcion z = sumar, indicamos los valores z = sumar (a,b); y retornamos mediante Console.WriteLine("" + z);
        
         Cerramos el algoritmo con Console.ReadKey();*/

        static int sumar(int a, int b)
        {
 
            int resultado;
            resultado = a + b;
            return resultado;

        }

        static int restar(int a, int b)
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

        /* primero, indicamos los datos que estan involucrados. luego, abrimos Console.WriteLine("ingrese dos numeros") seguidos por la asignacion de lo que escriba el usuario mediante int.Parse(Console.ReadLine());
         * y asignamos a una variable via a = int.Parse(Console.ReadLine());
         
         Luego, un condicional if a es diferente de 0 y b diferente de 0 mediante if (a!=0 && b!=0), dejaremos al usuario ingresar un numero para seleccionar la operacion. para esto, definimos la variable OP que almacenara
        la respuesta via op= int.Parse(Console.ReadLine());
        
         Luego definimos if condicionales si OP==1, 2, 3 o 4
        
         En todos los condicionales usamos la funcion mediante la variable z que almacenara el resultado de la funcion z = sumar, indicamos los valores z = sumar (a,b); y retornamos mediante Console.WriteLine("" + z);
        
         Cerramos el algoritmo con Console.ReadKey();*/

        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int op = 0;
            int z;

            Console.WriteLine("ingrese dos numeros");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            if (a != 0 && b != 0)
            {

                Console.WriteLine("eliga la operacion a realizar ");
                Console.WriteLine("1.suma");
                Console.WriteLine("2.resta");
                Console.WriteLine("3.multiplicacion");
                Console.WriteLine("4.division");
                op = int.Parse(Console.ReadLine());

                if (op == 1)
                {

                    z = sumar(a, b);

                    Console.WriteLine("el resultado de la suma es de : " + z);
 
                }
                else
                {

                    Console.Write("existe o existen numeros iguales a 0");

                    if (op == 2)
                    {

                        z = restar(a, b);
                        Console.WriteLine("el resultado de la resta es de : " + z);
                 
                    }
                    else
                    {

                        if (op == 3)
                        {

                            z = multiplicar(a, b);
                            Console.Write("el resultado de la multiplicacion es de : " + z);

                        }
                        else
                        {
                            if (op == 4)
                            {

                                z = dividir(a, b);
                                Console.Write("el resultado de la division es de :" + z);

                            }

                        }

                    }

                }


            }
            else
            {

                Console.Write("existe o existen numeros iguales a 0");

            }

            Console.ReadKey();

        }
    }
}
