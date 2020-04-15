using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory.PizzaParts.Meats
{
    class Ham : IMeat
    {
        public Ham()
        {
            Console.WriteLine("Added Ham");
        }
    }
}
