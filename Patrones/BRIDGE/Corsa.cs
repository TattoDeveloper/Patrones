using System;
namespace Patrones.BRIDGE
{
    public class Corsa : Vehiculo
    {

        public Corsa(IMOTOR motor) : base(motor)
        {
        }

        public override void MostrarCaracteristicas()
        {
            Console.WriteLine("capacidades del corsa...");
        }
    }
}
