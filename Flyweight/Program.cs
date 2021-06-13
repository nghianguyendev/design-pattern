using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;

using System;


namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Flyweight design pattern!");

            var serviceCollection = new ServiceCollection().AddMemoryCache().BuildServiceProvider();

            FlyweightFactory.cache = serviceCollection.GetService<IMemoryCache>();

            var countries = FlyweightFactory.GetCountries();

            // will be returned from Cache
            var countriesCalledFromOtherPlace = FlyweightFactory.GetCountries();

            Console.WriteLine("These countries will be returned from cache!");
            foreach (var item in countries)
            {
                Console.WriteLine($"Id: {item.Id} Name: {item.Name}");
            }

            Console.ReadKey();
        }
    }
}
