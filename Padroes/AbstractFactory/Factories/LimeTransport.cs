﻿using AbstractFactory.Aircrafts;
using AbstractFactory.LandVehicle;
using AbstractFactory.Landvehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    class LimeTransport : ITransportFactory
    {
        public IAircraft CreateTransportAircraft()
        {
            return new Drone();
        }

        public ILandVehicle CreateTransportVehicle()
        {
            return new Patinetes();
        }
    }
}
