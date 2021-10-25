using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    class Television : Electrodomestico
    {
        private int _resolucion;
        private bool _sintonizador;

        public Television() : base()
        {
            this._resolucion = 20;
            this._sintonizador = false;
        }

        public Television(double precio_base, double peso) : base(precio_base, peso)
        {
            this._resolucion = 20;
            this._sintonizador = false;
        }

        public Television(int _resolucion, bool sintonizador, double precio_base, double peso, char consumo, String color) : base(precio_base, peso, consumo, color)
        {
            this._resolucion = _resolucion;
            this._sintonizador = sintonizador;
        }

        public int getResolucion()
        {
            return this._resolucion;
        }

        public bool getSintonizador()
        {
            return this._sintonizador;
        }

        new public double precioFinal()
        {

            double extra = base.precioFinal();

            if (this._resolucion > 40)
            {
                extra += this._precio_base * 0.3;
            }
            if (this._sintonizador)
            {
                extra += 50;
            }

            return extra;
        }
    }
}
