using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioHerenciaWindowsForms
{
    abstract class Inmueble
    {
        protected int añosAntiguedad;
        protected string direccion;
        protected int estadoInmueble;
        protected int metrosCuadrado;
        protected double precioBase;

        public Inmueble(int añosAntiguedad,string Direccion,int estadoInmueble,int metrosCuadrado,double precioBase)
        {
            this.añosAntiguedad = añosAntiguedad;

            this.direccion = Direccion;

            this.estadoInmueble = estadoInmueble;

            this.metrosCuadrado = metrosCuadrado;

            this.precioBase = precioBase;
        }

        public virtual double calcularPrecio()
        {
            double precioCalculado=this.precioBase;

            if (this.añosAntiguedad >= 0 && this.añosAntiguedad<15)
            {
                precioCalculado -= ((this.precioBase / 100)); 
            }
            else
            {
                precioCalculado -= (((this.precioBase*2) / 100));
            }
            
            return precioCalculado;
        }

    }
}
