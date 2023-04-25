using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    internal class Program
    {
        //Sobreescritura De Metodos (Polimorfismo)
        static void Main(string[] args)
        {
            Gato g1 = new Gato();
            g1.Nombre = "Stiffler";

            Perro p1 = new Perro();
            p1.Nombre = "Annie";

            List<Animal> animales = new List<Animal>();
            animales.Add(g1);
            animales.Add(p1);
            animales.Add(new Pez());
            animales.Add(new Canario());
            animales.Add(new Aguila());
            animales.Add(new Gato());

            Console.WriteLine(g1.ToString());
            Console.WriteLine(g1.comunicarse());

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p1.comunicarse());

            Animal a2 = g1;
            Gato g8 = (Gato)a2;
            g8.Nombre = "Blanquito";

            Console.WriteLine(g1.Nombre);

            List<Flyable> listaVoladores = new List<Flyable>();
            listaVoladores.Add(new Canario());
            listaVoladores.Add(new Aguila());

            foreach(Animal item in animales)
            {
                Console.WriteLine(item.comunicarse());
            }

            Console.ReadKey();
        }
    }
}
