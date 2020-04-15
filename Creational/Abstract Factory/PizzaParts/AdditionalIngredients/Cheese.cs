using System;

namespace Abstract_Factory.PizzaParts.AdditionalIngredients
{
    public class Cheese : IAdditionalIngredients
    {
        public Cheese()
        {
            Console.WriteLine("Added Cheese");
        }
    }
}