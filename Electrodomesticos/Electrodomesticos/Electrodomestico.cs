using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    abstract class Electrodomestico
    {
        protected double _precio_base;
        protected String _color;
        protected char _consumo;
        protected double _peso;

        public Electrodomestico()
        {
            this._precio_base = 100.0;
            this._color = "blanco";
            this._consumo = 'F';
            this._peso = 5.0;
        }

        public Electrodomestico(double precio_base, double peso)
        {
            this._precio_base = precio_base;
            this._color = "blanco";
            this._consumo = 'F';
            this._peso = peso;
        }

        public Electrodomestico(double precio_base, double peso, char consumo, String color)
        {
            this._precio_base = precio_base;
            this._color = color;
            this._consumo = consumo;
            this._peso = peso;

            this.comprobarConsumoEnergetico(consumo);
            this.comprobarColor(color);
        }

        public double getPrecioBase()
        {
            return this._precio_base;
        }
        public double getPeso()
        {
            return this._peso;
        }

        private void comprobarColor(String color)
        {
            if (color != "blanco" || color != "negro" ||
                color != "rojo" || color != "azul" ||
                color != "gris")
            {
                this._color = "blanco";
            }
        }

        private void comprobarConsumoEnergetico(char consumoEnergetico)
        {
            String lower = consumoEnergetico.ToString().ToLower();
            
            if (lower != 'a'.ToString() || lower != 'b'.ToString() || 
                lower != 'c'.ToString() || lower != 'd'.ToString() || 
                lower != 'e'.ToString() || lower != 'f'.ToString())
            {
                this._consumo = 'F';
            }
        }

        public char getConsumoEnergetico()
        {
            return this._consumo;
        }

        public String getColor()
        {
            return this._color;
        }
        public double precioFinal()
        {
            double extra = 0;
            switch (this._consumo)
            {
                case 'A':
                    extra += 100;
                    break;
                case 'B':
                    extra += 80;
                    break;
                case 'C':
                    extra += 60;
                    break;
                case 'D':
                    extra += 50;
                    break;
                case 'E':
                    extra += 30;
                    break;
                case 'F':
                    extra += 10;
                    break;
            }

            if (this._peso >= 0 && this._peso < 19)
            {
                extra += 10;
            }
            else if (this._peso >= 20 && this._peso < 49)
            {
                extra += 50;
            }
            else if (this._peso >= 50 && this._peso <= 79)
            {
                extra += 80;
            }
            else if (this._peso >= 80)
            {
                extra += 100;
            }

            return this._precio_base + extra;
        }
    }
}
