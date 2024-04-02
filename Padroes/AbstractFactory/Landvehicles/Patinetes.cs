using AbstractFactory.LandVehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Landvehicles
{
    class Patinetes : ILandVehicle
    {
        public void Getcargo()
        {
            Console.WriteLine("Encomenda coletada");
        }

        public void StartRoute()
        {
            Getcargo();
            Console.WriteLine("Iniciando a entrega da emcomenda");
        }
    }
}
