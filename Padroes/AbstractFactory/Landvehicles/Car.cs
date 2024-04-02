
using AbstractFactory.LandVehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Landvehicles
{
    class Car : ILandVehicle
    {
        public void Getcargo()
        {
            Console.WriteLine("Pegamos os passageiros");
        }

        public void StartRoute()
        {
            Getcargo();
            Console.WriteLine("Iniciando o trajeto");
        }
    }
}
