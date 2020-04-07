using System;
using State.Tools;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
           var canvas = new Canvas();

           canvas.Tool = new Brush();
           canvas.MouseDown();
           canvas.MouseUp();

           canvas.Tool = new SelectionTool();
           canvas.MouseDown();
           canvas.MouseUp();

        }
    }
}
