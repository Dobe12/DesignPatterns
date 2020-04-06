using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class ImageStorage
    {
        private readonly IFilter _filter;
        private readonly ICompressor _compressor;

        public ImageStorage(IFilter filter, ICompressor compressor)
        {
            _filter = filter;
            _compressor = compressor;
        }

        public void Store(string fileName)
        {
            _filter.Apply(fileName);
            _compressor.Compress(fileName);
        }
    }
}
