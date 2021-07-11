using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Template Method design pattern!");
            var chess = new Chess();
            chess.Run();
        }
    }
}
