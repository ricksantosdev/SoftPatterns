using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Vehicle
{
    public interface IVehicle
    {
        void StartRoute();

        void GetCargo();
    }
}
