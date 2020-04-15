using System;
using System.Collections.Generic;
using System.Text;
using Abstract_Factory.PizzaParts.AdditionalIngredients;
using Abstract_Factory.PizzaParts.Meats;
using Abstract_Factory.PizzaParts.Sauce;

namespace Abstract_Factory
{
    public abstract class PizzaFactoryBase
    {
        public string Name { get; set; }

        public PizzaFactoryBase(string name)
        {
            Name = name;
        }

        public abstract IAdditionalIngredients AddAdditionalIngredients();
        public abstract ISauce AddSauce();
        public abstract IMeat AddMeat();

    }
}
