using System;
using Patrones.ADAPTER;
using Patrones.BRIDGE;
using Patrones.BUILDER;
using Patrones.FACADE;

namespace Patrones
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////// PATRÓN BUILDER ////////////////////

            DirectorCocina cocina = new DirectorCocina();
            cocina.setPizza(new PizzaHawainaBuilder());
            Pizza haw = cocina.makePizze();
            Console.WriteLine(haw.salsa);

            cocina.setPizza(new PizzaPeperoniBuilder());
            Pizza pep = cocina.makePizze();
            Console.WriteLine(pep.salsa);

            ////////// PATRÓN BUILDER ////////////////////


            //////////  USANDO ADAPTER /////////////////////

            runMotor( new MotorComun() );
            runMotor( new ElectricoAdapter());

            /// //////////  USANDO ADAPTER /////////////////////


            /// /// //////////  USANDO BRIDGE /////////////////////

            IMOTOR diesel = new MDisel();
            IMOTOR gasolina = new MGasolina();

            Vehiculo corsa = new Corsa(gasolina);

            corsa.MostrarCaracteristicas();

            Vehiculo skania = new Skania(diesel);
            skania.MostrarCaracteristicas();

            /// /// /// //////////  USANDO BRIDGE /////////////////////


            ///  /// /// /// //////////  USANDO FACADE /////////////////////

            IAcelerator acelerator = new Acelerador();
            IPalanca palanca = new Palanca();
            IEmbriague embriague = new Embriague();

            Facade facade = new Facade(embriague, palanca, acelerator);
            facade.Faster();
             
            /// ///  /// /// /// //////////  USANDO FACADE /////////////////////
        }

        public static void runMotor(Motor m ){
            m.Encender();
            m.Acelerar();
            m.Apagar();
        }
    }
}
