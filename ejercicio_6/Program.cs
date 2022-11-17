using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_6
{
    internal class Program
    {

        class Mascota
        {
            public string Nombre;
            public string Dueño;
            public int Edad;


            public string ObtenerNombre()
            {

                return (" el nombre de la mascota es :" + Nombre + " y el dueño se llama :" + Dueño);


            }

            public void AsignarEdad(int nuevaedad)
            {
                Edad = nuevaedad;


            }



        }



        static void Main(string[] args)
        {
            Mascota mascota1 = new Mascota();
            mascota1.Nombre = "Doggy ";
            mascota1.Dueño = "juanito";
            mascota1.AsignarEdad(8);

            Console.WriteLine("la edad de la mascota es de :" + mascota1.Edad + "años, y  " + "su nombre es :" + mascota1.Nombre + "y su dueño se llama :" + mascota1.Dueño);
            Console.ReadKey();

















        }
    }
}
