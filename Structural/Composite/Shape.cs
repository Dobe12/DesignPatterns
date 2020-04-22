using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Shape : IComponent
    {
        private string _name;
        public Shape(string name)
        {
            _name = name;
        }

        public void Move()
        {
            Console.WriteLine($"{_name} moving");
        }

        public void Remove()
        {
            Console.WriteLine($"{_name} removing");
        }

        public void Render()
        {
            Console.WriteLine($"Rendering {_name}");
        }
    }
}
