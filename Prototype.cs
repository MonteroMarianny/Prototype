using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
     class Prototype
    {
        static void Main(string[]args)
        {
            Carro oCarro = new Carro() { Marca = "Audi", Año = 2021 };
            Carro oCarro2 = oCarro;
            oCarro2.Año = 2022;

            Console.WriteLine(oCarro.Marca);
            Console.WriteLine(oCarro.Año);
            Console.WriteLine(oCarro2.Marca);
            Console.WriteLine(oCarro2.Año);
        }
    }
}
