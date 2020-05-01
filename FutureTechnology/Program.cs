using System;

namespace FutureTechnology
{
    class FutureTechnology
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            if (args.Length == 0)
            {
                Console.WriteLine("Provide an argument with the file path of image to transform");
                return;
            }

            var legacyProgram = new ImageResizeDemo.Program();
            legacyProgram.TransformImage(args[0]);
        }
    }
}
