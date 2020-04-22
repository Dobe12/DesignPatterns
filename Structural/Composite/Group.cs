using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Group : IComponent
    {

        private List<IComponent> _components = new List<IComponent>();
        public void Move()
        {
            foreach (var component in _components)
            {
                component.Move();
            }
        }

        public void Add(IComponent component)
        {
            _components.Add(component);
        }

        public void Remove()
        {
            foreach (var component in _components)
            {
                component.Remove();
            }
        }

        public void Render()
        {
            foreach (var component in _components)
            {
                component.Render();
            }
        }
    }
}
