using System;
using System.IO;
using ImageMagick;

namespace test_compress
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = new FileInfo("/home/app/zayn.png");
            var imageOptimizer = new ImageOptimizer
            {
                OptimalCompression = true,
                IgnoreUnsupportedFormats = true,
            };

            try
            {
                Console.WriteLine("Before " + file.Length);
                imageOptimizer.LosslessCompress(file);
                Console.WriteLine("This worked!!!");
                Console.WriteLine("After " + file.Length);
            }
            catch (Exception e)
            {
                Console.WriteLine("it failed!");
                Console.WriteLine(e.ToString());
            }

        }
    }
}
