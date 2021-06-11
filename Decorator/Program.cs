using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Decorator design pattern!");

            var legacyOldCar = new LegacyOldCar();
            Console.WriteLine("Name: " + legacyOldCar.GetName());
            Console.WriteLine("Cost: " + legacyOldCar.GetCost());

            var legacyCarWithNewIndicator = new LegacyOldCarWithNewIndicator(legacyOldCar);
            Console.WriteLine("Name: "+legacyCarWithNewIndicator.GetName());
            Console.WriteLine("Cost: "+legacyCarWithNewIndicator.GetCost());

            var legacyCarWithNewIndicatorAndWheel = new LegacyOldCarWithNewIndicatorAndWheel(legacyOldCar);
            Console.WriteLine("Name: " + legacyCarWithNewIndicatorAndWheel.GetName());
            Console.WriteLine("Cost: " + legacyCarWithNewIndicatorAndWheel.GetCost());
        }
    }
}
