using System;

namespace Bridge
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello Life without Bridge Design pattern!");

            var triangleVectorRenderer = new LifeWithoutBridge.TriangleVectorRenderer();
            Console.WriteLine(triangleVectorRenderer.Draw());

            var squareVectorRenderer = new LifeWithoutBridge.SquareVectorRenderer();
            Console.WriteLine(squareVectorRenderer.Draw());


            Console.WriteLine("Hello Bridge Design pattern!");

            var vectorRenderer = new VectorRenderer();
            var rasterRenderer = new RasterRenderer();

            var triangle = new Triangle(vectorRenderer);
            Console.WriteLine(triangle.Draw());

            var square = new Square(rasterRenderer);
            Console.WriteLine(square.Draw());
        }
    }
}