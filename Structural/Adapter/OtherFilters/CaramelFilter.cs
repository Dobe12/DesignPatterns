using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.OtherFilters
{
    class CaramelFilter
    {
        public void Render(Image image)
        {
            Console.WriteLine("Applying Caramel Filter");
        }
    }
}
