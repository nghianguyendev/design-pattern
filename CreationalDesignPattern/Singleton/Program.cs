using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Singleton design pattern!");
            var db = SingletonDatabase.Instance;

            var city = "saigon";
            Console.WriteLine($"{city} has population {db.GetPopulation(city)}");
        }
    }
}
