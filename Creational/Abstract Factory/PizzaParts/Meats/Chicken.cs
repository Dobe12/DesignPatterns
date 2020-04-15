using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory.PizzaParts.Meats
{
    class Chicken : IMeat
    {
        public Chicken()
        {
            Console.WriteLine("Added Chicken");
        }
    }
}
