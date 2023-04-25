using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases__Objetos__Propiedades_y_Encapsulamiento
{
    internal class Persona
    {
        //Persona: Edad, Sueldo, Nombre
        //Atributos o Miembros
        private int edad;
        private float sueldo;
        private string nombre;

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public void setEdad(int e)
        {
            edad = e;
        }

        public int getEdad()
        {
            return edad;
        }

        //Metodos
        public string saludar()
        {
            return "Hola Soy... " + nombre;
        }

        public string saludar (string personaje)
        {
            return "Hola " + personaje + ", soy..." + nombre;
        }
    }
}
