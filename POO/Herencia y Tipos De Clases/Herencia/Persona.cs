using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    //abstract (No se puede crear una nueva instancia(invocar) de la clase)
    //sealed (No permite heredar de la clase)
    //static (No puede heredad de otra clase, no hace falta instanciar/invocar para utilizarla)
    //static es muy pesado, se utiliza desde que se abre hasta que se cierra el programa
    internal class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Legajo { get; set; }
    }
}
