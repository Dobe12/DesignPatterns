using System;

namespace Abstract_Factory.PizzaParts.AdditionalIngredients
{
    public class PineApple : IAdditionalIngredients
    {
        public PineApple()
        {
            Console.WriteLine("Added PineApple");
        }
    }
}