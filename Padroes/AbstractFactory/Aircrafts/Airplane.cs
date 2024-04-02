using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Aircrafts
{
    class Airplane : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando os ventos, ventos a 30 km, ventos OK");
        }

        public void Getcarrgo()
        {
            Console.WriteLine(" Passageiros a bordo. Voo autorizado");
        }

        public void StartRoute()
        {
          CheckWind();
            Getcarrgo();
            Console.WriteLine("Iniciando decolagem");
        }
    }
}
