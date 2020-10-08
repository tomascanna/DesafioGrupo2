using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioHerenciaWindowsForms
{
    class Piso:Inmueble
    {
        private int numPisos;

        public Piso(int añosAntiguedad, String Direccion, int estadoInmueble, int metrosCuadrado, double precioBase,int numPisos) : base(añosAntiguedad, Direccion, estadoInmueble, metrosCuadrado, precioBase)
        {
            this.numPisos = numPisos;
        }

        public override double calcularPrecio()
        {
            double precioCalculadoPisos = base.calcularPrecio();
            if (this.numPisos >= 3)
            {
                precioCalculadoPisos += ((precioBase * 3) / 100) ;
            }

            return precioCalculadoPisos;
        }
    }
}
