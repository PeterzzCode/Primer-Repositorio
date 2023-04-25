using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Articulo
    {
        //- Codigo Articulo (3 digitos no correlativos)
        //- Precio
        //- Codigo De Marca (1 a 10)

        public int CodigoArticulo { get; set; }

        //private float precio;
        public float Precio { get; set; }

        private int codMarca;
        public int CodigoMarca
        {
            get { return codMarca; }

            set
            {
                if (value > 0 && value < 11)
                    codMarca = Value;
                else
                    codMarca = -1;
            }
    }
}
