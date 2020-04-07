using System;
using Adapter.Filters;
using Adapter.OtherFilters;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var imageView = new ImageView(new Image());
            imageView.ApplyFilter(new CaramelFilterAdapter(new CaramelFilter()));
        }
    }
}
