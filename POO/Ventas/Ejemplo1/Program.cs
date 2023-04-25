using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Primer lote con 10 registros de productos, cada producto tiene:
             * - Codigo Articulo (3 digitos no correlativos)
             * - Precio
             * - Codigo De Marca (1 a 10)
             * Segundo Lote con las ventas de la semana. Cada venta tiene:
             * - Codigo Articulo
             * - Cantidad
             * - Codigo CLiente (1 a 100)
             * Este lote corta con codigo de cliente cero.
             */
            Articulo[] articulos = new Articulo[10];

            for(int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese los datos del producto..");
                Console.WriteLine("Codigo: ");
                articulos[x].CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Precio: ");
                articulos[x].Precio = int.Parse(Console.ReadLine());
                Console.WriteLine("Marca (1 a 10): ");
                articulos[x].CodigoMarca = int.Parse(Console.ReadLine());
            }

            //Cargado el vector completo con los 10
            Venta venta = new Venta();
            Console.WriteLine("Ingrese La Venta: ");
            Console.WriteLine("Codigo Cliente: ");
            venta.CodigoCliente = int.Parse(Console.ReadLine());
            while(venta.CodigoCliente!=0)
            {
                Console.WriteLine("Codigo Articulo: ");
                venta.CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad: ");
                venta.Cantidad = int.Parse(Console.ReadLine());
                //Trabajamos...
                //Pido Cliente Nuevamente:
                Console.WriteLine("Ingrese La Venta: ");
                Console.WriteLine("Codigo Cliente: ");
                venta.CodigoCliente = int.Parse(Console.ReadLine());
            }
        }
    }
}
