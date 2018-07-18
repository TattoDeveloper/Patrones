using System;
namespace Patrones.FACADE
{
    public class Acelerador : IAcelerator
    {
        public Acelerador()
        {
            
        }

        public void acelerar()
        {
            Console.WriteLine("estoy acelerando....");
        }

        public void desacelerar()
        {
            Console.WriteLine("estoy desacelerando....");
        }
    }
}
