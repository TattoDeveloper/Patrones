using System;
namespace Patrones.BRIDGE
{
    public class MGasolina : IMOTOR
    {
        public MGasolina()
        {
        }

        public void gastarCombustible()
        {
            Console.WriteLine("gastando gasolina");
        }

        public void inyectarCombustible(int n)
        {
            Console.WriteLine("cargando gasolina");
        }
    }
}
