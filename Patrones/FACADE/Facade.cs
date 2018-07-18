using System;
namespace Patrones.FACADE
{
    public class Facade
    {
        private IEmbriague embriague;
        private IAcelerator acelerator;
        private IPalanca palanca;

        public Facade(IEmbriague embriague, IPalanca palanca, IAcelerator acelerator)
        {
            this.acelerator = acelerator;
            this.embriague = embriague;
            this.palanca = palanca;
                
        }

        public void Faster(){
            acelerator.desacelerar();
            embriague.presionar();
            palanca.neutra();
            if (palanca.getVelocidad() < 5){
                palanca.InsertarValocidad(palanca.getVelocidad() + 1);
            }
            embriague.soltar();
            acelerator.acelerar();
        }

        public void Slow()
        {
            acelerator.desacelerar();
            embriague.presionar();
            palanca.neutra();
            if (palanca.getVelocidad() >1)
            {
                palanca.InsertarValocidad(palanca.getVelocidad() - 1);
            }
            embriague.soltar();
            acelerator.acelerar();
        }
    }
}
