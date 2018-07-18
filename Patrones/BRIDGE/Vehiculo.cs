using System;
namespace Patrones.BRIDGE
{
    public abstract class Vehiculo
    {
        private IMOTOR m;
        public Vehiculo(IMOTOR motor)
        {
            m = motor;
        }

        public void Acelerar(int n){
            m.inyectarCombustible(n);
            m.gastarCombustible();
        }

        public void Frenar(){
            Console.WriteLine("frenando...");
        }

        public abstract void MostrarCaracteristicas();
    }
}
