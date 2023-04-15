using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Vehicle
{
    public class CarVehicle : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Iniciando trajeto do passageiro");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando Rota");
        }
    }
}
