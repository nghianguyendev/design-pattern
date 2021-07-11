using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello State design pattern!");

            var sw = new Switch();
            sw.On();
            sw.On();
            sw.Off();
            sw.Off();
            sw.On();
        }
    }
}
