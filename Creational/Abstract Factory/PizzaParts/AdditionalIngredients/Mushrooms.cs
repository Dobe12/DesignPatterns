using System;

namespace Abstract_Factory.PizzaParts.AdditionalIngredients
{
    public class Mushrooms : IAdditionalIngredients
    {
        public Mushrooms()
        {
            Console.WriteLine("Added Mushrooms");
        }
    }
}