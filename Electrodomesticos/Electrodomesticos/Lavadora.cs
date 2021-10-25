using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    class Lavadora : Electrodomestico
    {
        private int _carga;

        public Lavadora() : base()
        {
            this._carga = 5;
        }

        public Lavadora(double precio_base, double peso) : base(precio_base, peso)
        {
            this._carga = 5;
        }

        public Lavadora(int carga, double precio_base, double peso, char consumo, String color) : base(precio_base, peso, consumo, color)
        {
            this._carga = carga;
        }

        public int getCarga()
        {
            return this._carga;
        }

        new public double precioFinal()
        {
            double extra = base.precioFinal();

            if (this._carga > 30)
                extra += 50;

            return extra;
        }
    }
}
