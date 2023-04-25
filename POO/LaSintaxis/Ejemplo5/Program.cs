using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Funciones...
            string aloh = saludar("Peter");
            Console.WriteLine(aloh);
            Console.ReadKey;

            int b = 10;
            sumar(2, ref b);
        }

        static int sumar(int a, int z)
        {
            return a + z;
        }

        static string saludas(string nombre)
        {
            return "Hola " + nombre;
        }
    }
}
