using Factory.Vehicle;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.FactoryVehicle
{
    public abstract class Transport
    {
       
        public void StartTranport()
        {
            IVehicle vehicle = CreateTransport();
            vehicle.StartRoute();
        }

        public abstract IVehicle CreateTransport();
    }
}
