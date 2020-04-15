using System;
using System.Collections.Generic;
using System.Text;
using Abstract_Factory.PizzaParts.AdditionalIngredients;
using Abstract_Factory.PizzaParts.Meats;
using Abstract_Factory.PizzaParts.Sauce;

namespace Abstract_Factory.PizzaFactorys
{
    class PepperoniPizzaFactory : PizzaFactoryBase
    {
        public PepperoniPizzaFactory(string name) : base(name)
        {
        }

        public override IAdditionalIngredients AddAdditionalIngredients()
        {
            return new Cheese();
        }

        public override ISauce AddSauce()
        {
            return  new Ketchup();
        }

        public override IMeat AddMeat()
        {
            return  new Pepperoni();
        }
    }
}
