using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class PngCompressor : ICompressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine("Compressing using PNG");
        }
    }
}
