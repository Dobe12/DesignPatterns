using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var squareGroup = new Group();
            squareGroup.Add(new Shape("White square"));
            squareGroup.Add(new Shape("Black square"));

            var circleGroup = new Group();
            circleGroup.Add(new Shape("Blue circle"));
            circleGroup.Add(new Shape("Green circle"));

            var shapeGroup = new Group();
            shapeGroup.Add(squareGroup);
            shapeGroup.Add(circleGroup);

            shapeGroup.Render();
            shapeGroup.Move();
            shapeGroup.Render();

            Console.ReadKey();
        }
    }
}
