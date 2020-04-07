using System;
using System.Collections.Generic;
using System.Text;

namespace State.Tools
{
    class Brush : ITool
    {
        public void MouseUp()
        {
            Console.WriteLine("Draw a line");
        }

        public void MouseDown()
        {
            Console.WriteLine("Brush icon");
        }
    }
}
