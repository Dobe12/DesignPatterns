using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public interface IComponent
    {
        void Render();
        void Remove();
        void Move();
    }
}
