using System;
namespace Patrones.BRIDGE
{
    public class MDisel : IMOTOR
    {
        public MDisel()
        {
        }

        public void gastarCombustible()
        {
            Console.WriteLine("gastando diesel");
        }

        public void inyectarCombustible(int n)
        {
            Console.WriteLine("cargando diesel");
        }
    }
}
