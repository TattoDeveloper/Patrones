using System;
namespace Patrones.BUILDER
{
    public class PizzaHawainaBuilder : PizzaBuilder
    {
        public PizzaHawainaBuilder()
        {
            pizza = new Pizza();
        }

        public override void creaeRelleno()
        {
            pizza.masa = "Relleno de hawaina";
        }

        public override void crearMaza()
        {
            pizza.salsa = "Maza de hawaina";
        }

        public override void crearSalsa()
        {
            pizza.relleno = "Salsa de hawaina";
        }
    }
}
