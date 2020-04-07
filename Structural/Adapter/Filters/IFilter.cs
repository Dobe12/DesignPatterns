using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Filters
{
    public interface IFilter
    {
        void Apply(Image image);
    }
}
