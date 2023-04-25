using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases__Objetos__Propiedades_y_Encapsulamiento
{
    //Capacidad Maxima : 100
    //Cantidad Actual: Inicia en Cero
    //Metodo Recarga: Carga al 100 y Devuelve el costo de recargar. 50 cada 100

    internal class Botella
    {
        //Constructor
        public Botella(string color, string material)
        {
            this.color = color;
            this.material = material;
            capacidad = 100;
            cantidadActual = 0;
        }
        // Sobrecargar El Constructor
        public Botella()
        {

        }

        ~Botella()
        {
            //La Logica..
        }
        //Botella: Capacidad, Color, Material
        private int capacidad;
        private string color;
        private string material;

        private int cantidadActual;

        //Propiedad

        public string Material
        {
            get { return material; }
        }
        public int CantidadActual
        {
            get { return cantidadActual; }
        }
        public int Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }

        //Metodos
        public float recargar()
        {
            if (cantidadActual > 0)
            {
                int dif = 100 - cantidadActual;
                //100 50
                //dif
                float monto = dif * 50 / 100;
                cantidadActual += dif;
                return monto;
            }
            cantidadActual = 100;
            return 50;
        }

        public float recargar(int cantidad)
        {
            cantidadActual += cantidad;
                return cantidad * 50 / 100;
            //100 50
            //cant x=??

        }
    }
}
