using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory.PizzaParts.Meats
{
    class Pepperoni : IMeat
    {
        public Pepperoni()
        {
            Console.WriteLine("Added pepperoni");
        }
    }
}
