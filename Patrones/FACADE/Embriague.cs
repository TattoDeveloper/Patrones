using System;
namespace Patrones.FACADE
{
    public class Embriague : IEmbriague
    {
        public Embriague()
        {
        }

        public void presionar()
        {
            Console.WriteLine("embriagando...");
        }

        public void soltar()
        {
            Console.WriteLine("desembriagando...");
        }
    }
}
