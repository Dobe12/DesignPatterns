using System;
using System.Collections.Generic;
using System.Text;
using Abstract_Factory.PizzaParts.AdditionalIngredients;
using Abstract_Factory.PizzaParts.Meats;
using Abstract_Factory.PizzaParts.Sauce;

namespace Abstract_Factory.PizzaFactorys
{
    class FourSeasonsPizzaFactory : PizzaFactoryBase
    {
        public FourSeasonsPizzaFactory(string name) : base(name)
        {
        }

        public override IAdditionalIngredients AddAdditionalIngredients()
        {
            return new Mushrooms();
        }

        public override ISauce AddSauce()
        {
            return new ChiliSause();
        }

        public override IMeat AddMeat()
        {
            return new Chicken();
        }
    }
}
