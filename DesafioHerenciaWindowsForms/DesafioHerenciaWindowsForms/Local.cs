using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioHerenciaWindowsForms
{
    class Local : Inmueble
    {
        private int numVentanas;

        public Local (int añosAntiguedad, string Direccion, int estadoInmueble, int metrosCuadrado, double precioBase, int numVentanas) : base(añosAntiguedad, Direccion, estadoInmueble, metrosCuadrado, precioBase)
        {
            this.numVentanas = numVentanas;
        }

        public override double calcularPrecio()
        {
            double precioCalculadoLocal= base.calcularPrecio();
            
            if (numVentanas <= 1)
            {
                precioCalculadoLocal -= ((precioBase * 2) / 100);
            }

            if (numVentanas > 4)
            {
                precioCalculadoLocal +=((precioBase * 2) / 100);
            }

            if (metrosCuadrado > 50)
            {
                precioCalculadoLocal +=((precioBase * 1) / 100);
            }

            return precioCalculadoLocal;

        }
    }
}
