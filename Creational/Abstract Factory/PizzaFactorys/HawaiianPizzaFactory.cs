using System;
using System.Collections.Generic;
using System.Text;
using Abstract_Factory.PizzaParts.AdditionalIngredients;
using Abstract_Factory.PizzaParts.Meats;
using Abstract_Factory.PizzaParts.Sauce;

namespace Abstract_Factory.PizzaFactorys
{
    class HawaiianPizzaFactory : PizzaFactoryBase
    {
        public HawaiianPizzaFactory(string name) : base(name)
        {
        }

        public override IAdditionalIngredients AddAdditionalIngredients()
        {
            return new PineApple();
        }

        public override ISauce AddSauce()
        {
            return new SweetSauce();
        }

        public override IMeat AddMeat()
        {
            return  new Chicken();
        }
    }
}
