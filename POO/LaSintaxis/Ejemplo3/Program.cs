using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ciclos
            //for, while, do while
            int a = 10;
            for(int x = 0; x < 10; x++)
            {
                while (a != 0)
                {
                    Console.WriteLine("Hola " + x);
                    a--;
                }
            }
        }
    }
}
