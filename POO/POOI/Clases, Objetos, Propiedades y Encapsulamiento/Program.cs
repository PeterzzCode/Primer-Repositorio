using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases__Objetos__Propiedades_y_Encapsulamiento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Persona: Edad, Sueldo, Nombre
            //int edad;
            //float sueldo;
            //string nombre;

            Persona p1 = new Persona("Peter");
            p1.setEdad(20);

            Console.WriteLine(p1.saludar());
            Console.WriteLine(p1.saludar("Maxi"));
            Console.WriteLine("La Edad De La Persona Es: " + p1.getEdad());
            Console.ReadKey();


            Botella b1 = new Botella("Rojo", "Plastico");
            b1.Capacidad = 200;

            int algo = b1.Capacidad;

            Console.WriteLine("Capacidad Botella: " + b1.Capacidad);
            Console.WriteLine("La Cantidad Actual Es: " + b1.CantidadActual);

            b1.recargar(20);
            Console.WriteLine("Luego De Recargar La Cantidad Actual Es: " + b1.CantidadActual);

            b1.recargar();
            Console.WriteLine("Luego De Recargar La Cantidad Actual Es: " + b1.CantidadActual);

            Console.ReadKey();

        }
    }
}
