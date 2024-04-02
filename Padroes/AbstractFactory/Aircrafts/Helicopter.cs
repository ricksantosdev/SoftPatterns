using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Aircrafts
{
    class Helicopter : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando vento, vento sudeste, ventos ok");
        }

        public void Getcarrgo()
        {
            Console.WriteLine("Passageiros ok, ligando as helices");
        }

        public void StartRoute()
        {
            CheckWind();
            Getcarrgo();
            Console.WriteLine("Inciando a decolagem");
        }
    }
}
