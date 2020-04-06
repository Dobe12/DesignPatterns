using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class HighContrastFilter : IFilter
    {
        public void Apply(string fileName)
        {
            Console.WriteLine("Applying high contrast filter");
        }
    }
}
