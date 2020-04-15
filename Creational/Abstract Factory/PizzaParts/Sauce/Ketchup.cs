using System;

namespace Abstract_Factory.PizzaParts.Sauce
{
    class Ketchup : ISauce
    {
        public Ketchup()
        {
            Console.WriteLine("Added Ketchup");
        }
    }
}