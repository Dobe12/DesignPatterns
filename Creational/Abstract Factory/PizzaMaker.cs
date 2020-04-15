using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    public class PizzaMaker
    {
        public PizzaMaker(PizzaFactoryBase factory)
        {
            factory.AddAdditionalIngredients();
            factory.AddMeat();
            factory.AddSauce();

            Console.WriteLine($"Pizza {factory.Name} is done!!!");
        }
    }
}
