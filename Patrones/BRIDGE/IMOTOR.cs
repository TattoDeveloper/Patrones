using System;
namespace Patrones.BRIDGE
{
    public interface IMOTOR
    {
        void inyectarCombustible(int n);
        void gastarCombustible();
    }
}
