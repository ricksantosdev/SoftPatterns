using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Aircrafts
{
    class Drone : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Checando os ventos para decolagem do Drone");
        }

        public void Getcarrgo()
        {
            Console.WriteLine("Pegamos a encomenda");
        }

        public void StartRoute()
        {
            CheckWind();
            Getcarrgo();
            Console.WriteLine("Iniciando a entrega da emcomenda..via drone");
        }
    }
}
