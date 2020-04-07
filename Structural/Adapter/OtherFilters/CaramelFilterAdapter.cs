using System;
using System.Collections.Generic;
using System.Text;
using Adapter.Filters;

namespace Adapter.OtherFilters
{
    class CaramelFilterAdapter : IFilter
    {
        private CaramelFilter CaramelFilter { get; set; }
        public CaramelFilterAdapter(CaramelFilter caramelFilter)
        {
            CaramelFilter = caramelFilter;
        }

        public void Apply(Image image)
        {
           CaramelFilter.Render(image);
        }
    }
}
