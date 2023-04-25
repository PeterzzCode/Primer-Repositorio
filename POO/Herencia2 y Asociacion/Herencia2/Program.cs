using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    internal class Program
    {
        //Herencia Se Lee "Es"
        //Composicion Se Lee "Tiene"
        static void Main(string[] args)
        {
            //Vehiculo > Auto > AutoDeportivo > AutoUrbano
            //>Camioneta
            //>Moto
            Vehiculo v1 = new Vehiculo();
            Camioneta c1 = new Camioneta();
            c1.Color = "Amarillo";
            Camioneta c2 = new Camioneta();
            c2.Color = "Roja";
            Camioneta c3 = new Camioneta();
            c3.Color = "Blanca";

            Vehiculo v2;
            v2 = new Camioneta();

            List<Camioneta> listaCamionetas = new List<Camioneta>();
            listaCamionetas.Add(c1);
            listaCamionetas.Add(c2);
            listaCamionetas.Add(c3);

            Console.WriteLine("La cantidad de camionetas es: " + listaCamionetas.Count);
            //listaCamionetas[1].Color = "Negra";
            c2.Color = "Verde";
            Console.WriteLine("El Color Es: " + listaCamionetas[1].Color);
            listaCamionetas.Remove(c3);
            Console.WriteLine("La cantidad de camionetas es: " + listaCamionetas.Count);

            foreach(Camioneta item in listaCamionetas)
            {
                Console.WriteLine("Color: " + item.Color);
            }

            Auto auto1 = new Auto();

            auto1.Motor = new Motor();

            Console.ReadKey();
        }
    }
}
