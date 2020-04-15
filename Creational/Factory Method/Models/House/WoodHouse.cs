using System;
using System.Collections.Generic;
using System.Text;
using Factory_Method.Models.House;

namespace Factory_Method.Models
{
    public class WoodHouse : IHouse
    {
        public WoodHouse()
        {
            Console.WriteLine("Wood house was created!");
        }
    }
}
