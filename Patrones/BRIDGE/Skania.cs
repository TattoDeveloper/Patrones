using System;
namespace Patrones.BRIDGE
{
    public class Skania : Vehiculo
    {
        public Skania(IMOTOR motor) : base(motor)
        {
        }

        public override void MostrarCaracteristicas()
        {
            Console.WriteLine("capacidad de toneladas");
        }
    }
}
