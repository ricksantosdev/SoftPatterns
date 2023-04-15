using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Vehicle
{
    public class BikeVehicle : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Foi coletado alimento do cabra");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciado processo de entrega do lanche do cabra");
        }
    }
}
