using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        public string Nombre;
        public string Alumno;
        public int Semestre;


        public void AsignarNombre(string name, string alu)
        {
            Nombre = name;
            Alumno = alu;


        }

        public string obtenerDatos()
        {

            return (Nombre + Alumno);

        }



    }


    static void Main(string[] args)
    {
        Asignatura asignatura1 = new Asignatura();
        asignatura1.Nombre = "Poto";
        asignatura1.Alumno = "pelao";
        asignatura1.obtenerDatos();
        Console.WriteLine(asignatura1.obtenerDatos());
        Console.ReadKey();


    }


}
