using Factory.Vehicle;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.FactoryVehicle
{
    public class CarTranport : Transport
    {
        public override IVehicle CreateTransport()
        {
            return new CarVehicle();
        }
    }
}
