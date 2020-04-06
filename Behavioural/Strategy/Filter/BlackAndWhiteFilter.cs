using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class BlackAndWhiteFilter : IFilter
    {
        public void Apply(string fileName)
        {
            Console.WriteLine("Applying Black & White filter");
        }
    }
}
