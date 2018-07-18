using System;
namespace Patrones.ADAPTER
{
    public class MotorComun : Motor
    {
        public MotorComun()
        {
        }

        public void Acelerar()
        {
            Console.WriteLine("acelerando común");
        }

        public void Apagar()
        {
            Console.WriteLine("apagar común");
        }

        public void Encender()
        {
            Console.WriteLine("encender común");
        }
    }
}
