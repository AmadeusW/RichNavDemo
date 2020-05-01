using System;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

namespace ImageResizeDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var program = new Program();
            program.TransformImage(@"D:\Untitled.png");
        }

        public void TransformImage(string path)
        {
            var image = Image.Load(path);
            //image.Mutate();
            image.Save(path);
        }
    }
}
