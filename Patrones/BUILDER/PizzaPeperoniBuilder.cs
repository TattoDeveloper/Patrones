using System;
namespace Patrones.BUILDER
{
    public class PizzaPeperoniBuilder : PizzaBuilder
    {
        public PizzaPeperoniBuilder()
        {
            pizza = new Pizza(); 
        }

        public override void creaeRelleno()
        {
            pizza.relleno = "Relleno peperoni";
        }

        public override void crearMaza()
        {
            pizza.masa = "Masa peperoni";
        }

        public override void crearSalsa()
        {
            pizza.salsa = "Salsa peperoni";
        }
    }
}
