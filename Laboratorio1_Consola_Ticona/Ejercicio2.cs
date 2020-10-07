using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1_Consola_Ticona
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            string nombre = "Jhon";
            string apellido = "Ticona";
            int edad = 23;
            double talla = 1.67;
            bool sexo = true;

            Console.WriteLine("Nombre : "+nombre);
            Console.WriteLine("Apellido : " + apellido);
            Console.WriteLine("Edad : " + edad);
            Console.WriteLine("Estatura : " + talla);

            if (sexo == true)
            {
                Console.WriteLine("Sexo : " + "M");
            }
            else
            {
                Console.WriteLine("Sexo : " + "F");
            }
            Console.ReadKey();
        }
    }
}
