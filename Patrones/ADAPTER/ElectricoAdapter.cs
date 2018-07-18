using System;
namespace Patrones.ADAPTER
{
    public class ElectricoAdapter : Motor

    {
        private MotorElectrico electrico;

        public ElectricoAdapter()
        {
            electrico = new MotorElectrico();
        }

        public void Acelerar()
        {
            electrico.mover();
        }

        public void Apagar()
        {
            electrico.detener();
            electrico.desconectar();
        }

        public void Encender()
        {
            electrico.conectar();
            electrico.activar();
        }
    }
}
