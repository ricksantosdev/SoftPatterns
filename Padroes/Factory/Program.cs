using Factory.FactoryVehicle;
using System;

namespace Factory
{
    public  class Program
    {
        static void Main(string[] args)
        {
            Transport transport = null;
            if(args.Length > 0 && args[0] == "carro")
            {
                transport = new CarTranport();

            }else if (args.Length > 0 && args[0] == "moto")
            {
                transport = new MotorcycleTransport();
            }else if (args.Length > 0 && args[0] == "bike")
            {
                transport = new BikeTransport();
            }
            else
            {
                Console.WriteLine("Inicialize algum serviço");
            }

            if(transport != null)
            {
                transport.StartTranport(); 
            }

            Console.ReadKey();
        }
    }
}
