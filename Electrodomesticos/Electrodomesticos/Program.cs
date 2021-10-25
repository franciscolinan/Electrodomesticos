using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Electrodomestico> electrodomesticos = new List<Electrodomestico>();
            electrodomesticos.Add(new Lavadora(200, 100));
            electrodomesticos.Add(new Television());
            electrodomesticos.Add(new Television(40, true, 1000.0, 60.0, 'A', "gris"));

            double total = 0;

            int lavadora = 0;
            int televisor = 0;

            foreach (Electrodomestico electrodomestico in electrodomesticos)
            {
                total += electrodomestico.precioFinal();

                if (electrodomestico.GetType() == typeof(Lavadora))
                {
                    lavadora++;
                    Console.WriteLine("El precio de la lavadora " + lavadora + " es " + electrodomestico.precioFinal());

                }
                if (electrodomestico.GetType() == typeof(Television))
                {
                    televisor++;
                    Console.WriteLine("El precio del televisor " + televisor + " es " + electrodomestico.precioFinal());
                }
            }

            Console.WriteLine("La suma del precio de los electrodomesticos es de " + total);
            Console.ReadLine();
        }
    }
}
