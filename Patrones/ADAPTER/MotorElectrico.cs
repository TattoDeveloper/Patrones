using System;
namespace Patrones.ADAPTER
{
    public class MotorElectrico
    {
        public void conectar(){
            Console.WriteLine("conecatando electrico");
        }

        public void activar()
        {
            Console.WriteLine("activando electrico");
        }

        public void mover()
        {
            Console.WriteLine("acelerando electrico");
        }

        public void detener()
        {
            Console.WriteLine("parando electrico");
        }

        public void desconectar()
        {
            Console.WriteLine("apagando electrico");
        }
    }
}
