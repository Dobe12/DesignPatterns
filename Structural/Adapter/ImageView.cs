using System;
using System.Collections.Generic;
using System.Text;
using Adapter.Filters;

namespace Adapter
{
    public class ImageView
    {
        private Image Image { get; set; }

        public ImageView(Image image)
        {
            Image = image;
        }

        public void ApplyFilter(IFilter filter)
        {
            filter.Apply(Image);
        }
    }
}
