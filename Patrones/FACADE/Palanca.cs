using System;
namespace Patrones.FACADE
{
    public class Palanca : IPalanca
    {
        private int velocidad = 0;
        public Palanca()
        {
        }

        public int getVelocidad()
        {
            return velocidad;
        }

        public void InsertarValocidad(int vel)
        {
            velocidad = vel;
        }

        public void neutra()
        {
            Console.WriteLine("estoy neutro....");
        }
    }
}
