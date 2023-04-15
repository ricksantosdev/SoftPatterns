using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Vehicle
{
    public class MotorCycleVehivle : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Coletado entrega do produto");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando entrega do pacote");
        }
    }
}
