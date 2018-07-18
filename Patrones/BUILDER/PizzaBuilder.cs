using System;
namespace Patrones.BUILDER
{
    public abstract class PizzaBuilder
    {
        protected Pizza pizza;
        public void crearPizza(){}
        public Pizza GetPizza(){
            return pizza;
        }

        public abstract void crearMaza();
        public abstract void crearSalsa();
        public abstract void creaeRelleno();
    }
}
