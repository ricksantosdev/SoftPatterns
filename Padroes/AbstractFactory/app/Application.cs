using AbstractFactory.Aircrafts;
using AbstractFactory.Factories;
using AbstractFactory.LandVehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.app
{
    class Application
    {
        private IAircraft _aircraft;
        private ILandVehicle _landVehicle;

        public Application(ITransportFactory factory)
        {
            _aircraft = factory.CreateTransportAircraft();
            _landVehicle = factory.CreateTransportVehicle();
        }

        public void StartRoute()
        {
            _aircraft.StartRoute();
            _landVehicle.StartRoute();
        }
    }
}
