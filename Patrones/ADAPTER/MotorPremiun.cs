using System;
namespace Patrones.ADAPTER
{
    public class MotorPremiun : Motor
    {
        public MotorPremiun()
        {
        }

        public void Acelerar()
        {
            Console.WriteLine("acelerando premiun");
        }

        public void Apagar()
        {
            Console.WriteLine("apagar premiun");
        }

        public void Encender()
        {
            Console.WriteLine("Encender premiun");
        }
    }
}
