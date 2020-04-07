using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Filters
{
    class VividFilter : IFilter
    {
        public void Apply(Image image)
        {
            Console.WriteLine("Applying Vivid Filter");
        }
    }
}
