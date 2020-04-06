using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var jpegImageStorage = new ImageStorage(new HighContrastFilter(), new JpegCompressor());
            jpegImageStorage.Store("A.jpeg");

            var pngImageStorage = new ImageStorage(new BlackAndWhiteFilter(), new PngCompressor());
            pngImageStorage.Store("B.png");
        }
    }
}
