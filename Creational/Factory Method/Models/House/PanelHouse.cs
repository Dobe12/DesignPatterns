using System;
using System.Collections.Generic;
using System.Text;
using Factory_Method.Models.House;

namespace Factory_Method.Models
{
    class PanelHouse : IHouse
    {
        public PanelHouse()
        {
            Console.WriteLine("Panel house was created!");
        }
    }
}
