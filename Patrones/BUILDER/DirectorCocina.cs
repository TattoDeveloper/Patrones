using System;
namespace Patrones.BUILDER
{
    public class DirectorCocina
    {
        private PizzaBuilder Pizza;
        public DirectorCocina()
        {
        }

        public void setPizza(PizzaBuilder pizzaBuilder){

            Pizza = pizzaBuilder;

        }

        public Pizza makePizze(){
            Pizza.creaeRelleno();
            Pizza.crearSalsa();
            Pizza.crearMaza();
            return Pizza.GetPizza();
        }
    }
}
