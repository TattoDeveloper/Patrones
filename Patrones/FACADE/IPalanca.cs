using System;
namespace Patrones.FACADE
{
    public interface IPalanca
    {
        void InsertarValocidad(int vel);
        void neutra();
        int getVelocidad();
    }
}
